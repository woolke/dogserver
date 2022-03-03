package pl.wolke.doghouse.dto.calendar;

import lombok.Builder;
import lombok.Data;
import lombok.Getter;
import lombok.Setter;
import pl.wolke.doghouse.config.security.User;
import pl.wolke.doghouse.dto.UserDto;

import javax.persistence.*;
import java.util.Date;

@Setter
@Getter
@Builder
public class CalendarEventDto {
    private int id;
    private String dateFrom;
    private String dateTo;
    private String color;
    private String commonKey;
    private String title;
    private boolean allDay;
    private String description;
    private String icon;
    private UserDto user;
    private UserDto manager;
}
