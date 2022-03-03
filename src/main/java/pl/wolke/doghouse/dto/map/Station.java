package pl.wolke.doghouse.dto.map;

import lombok.*;

@NoArgsConstructor
@Getter
@Setter
public class Station {
        public int id;
        public String stationName;
        public String gegrLat;
        public String gegrLon;
        public City city;
        public String addressStreet;
}
