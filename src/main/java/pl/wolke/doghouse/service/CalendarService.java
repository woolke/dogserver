package pl.wolke.doghouse.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import pl.wolke.doghouse.dao.CalendarEventRepository;
import pl.wolke.doghouse.entity.CalendarEvent;

import javax.transaction.Transactional;
import java.util.*;

import static pl.wolke.doghouse.utils.StaticFunc.*;

@Service
public class CalendarService {

    private final CalendarEventRepository calendarEventRepository;

    @Autowired
    public CalendarService(CalendarEventRepository calendarEventRepository) {
        this.calendarEventRepository = calendarEventRepository;
    }

    public Set<CalendarEvent> getEvents(Date start, Date end) {
        return calendarEventRepository.findByDateToGreaterThanEqualAndDateFromLessThanEqual(start, end);
    }


    @Transactional
    public boolean save(CalendarEvent event) {
        if (event.getCommonKey() != null) {
            calendarEventRepository.deleteAllByCommonKeyEquals(event.getCommonKey());
        }
        if (event.isAllDay() || equalsWithoutTime(event.getDateFrom(), event.getDateTo())) {
            if (event.isAllDay()) {
                event.setDateFrom(removeTime(event.getDateFrom()));
                event.setDateTo(removeTime(event.getDateTo()));
            }
            event.setCommonKey(UUID.randomUUID().toString());
            calendarEventRepository.save(event);
        } else {
            calendarEventRepository.saveAll(
                    event.convertEventToSingleEvents(UUID.randomUUID().toString())
            );
        }
        return true;
    }

    @Transactional
    public Status delete(Integer id, boolean confirm, boolean deleteWithCommon) {
        try {
            Optional<CalendarEvent> event = calendarEventRepository.findById(id);
            if (!event.isPresent())
                return Status.LACK;
            boolean multi = calendarEventRepository.countAllByCommonKey(event.get().getCommonKey()) > 1;
            if (!confirm) {
                if (multi)
                    return Status.CONFIRM_MULTI;
                else
                    return Status.CONFIRM;
            } else if (multi && Objects.equals(deleteWithCommon, false)) {
                calendarEventRepository.delete(event.get());
            } else {
                calendarEventRepository.deleteAllByCommonKeyEquals(event.get().getCommonKey());
            }
            return Status.OK;
        } catch (Exception e) {
            e.printStackTrace();
            return Status.ERROR;
        }
    }

    @Transactional
    public Status resize(Integer id, Date endDate, boolean confirm, boolean resizeAll) {
        try {
            Optional<CalendarEvent> event = calendarEventRepository.findById(id);
            Set<CalendarEvent> events = new HashSet<>();
            if (!event.isPresent())
                return Status.LACK;
            boolean multi = calendarEventRepository.countAllByCommonKey(event.get().getCommonKey()) > 1;
            if (!confirm && multi) {
                    return Status.CONFIRM_MULTI;
            } else if (multi && Objects.equals(resizeAll, true)) {
                events = calendarEventRepository.findByCommonKey(event.get().getCommonKey());
            } else {
                events.add(event.get());
            }
            String timeString = CalendarEvent.sdfMinutes.format(endDate);
            for (CalendarEvent calendarEvent : events) {
                String dayString = CalendarEvent.sdfDay.format(calendarEvent.getDateTo());
                calendarEvent.setDateTo(CalendarEvent.sdf.parse(dayString + " " + timeString));
            }
            calendarEventRepository.saveAll(events);
            return Status.OK;
        } catch (Exception e) {
            e.printStackTrace();
            return Status.ERROR;
        }
    }

    @Transactional
    public Status move(Integer id, Date startDate, Date endDate, boolean allDay, boolean confirm, boolean resizeAll) {
        try {
            Optional<CalendarEvent> event = calendarEventRepository.findById(id);
            if (!event.isPresent())
                return Status.LACK;
            boolean multi = calendarEventRepository.countAllByCommonKey(event.get().getCommonKey()) > 1;
            if (!confirm && multi) {
                return Status.CONFIRM_MULTI;
            } else if (multi && Objects.equals(resizeAll, true)) {
                event.get().setCommonKey(UUID.randomUUID().toString());
            }
            event.get().setDateFrom(startDate);
            event.get().setDateTo(endDate);
            event.get().setAllDay(allDay);
            calendarEventRepository.save(event.get());
            return Status.OK;
        } catch (Exception e) {
            e.printStackTrace();
            return Status.ERROR;
        }
    }

    public enum Status {
        OK, CONFIRM, CONFIRM_MULTI, LACK, ERROR
    }
}
