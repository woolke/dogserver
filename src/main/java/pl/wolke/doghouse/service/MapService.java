package pl.wolke.doghouse.service;

import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpMethod;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;
import pl.wolke.doghouse.dto.map.Station;

import java.util.Objects;

@Service
public class MapService {
    RestTemplate restTemplate = new RestTemplate();
    public Station[] findAllStation() {
        HttpEntity httpEntity = new HttpEntity(new HttpHeaders());
        ResponseEntity<Station[]> exchange = restTemplate.exchange("http://api.gios.gov.pl/pjp-api/rest/station/findAll",
                HttpMethod.GET,
                httpEntity,
                Station[].class);
        return Objects.requireNonNull(exchange.getBody());
    }

}
