package pl.wolke.doghouse.dto.map;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@NoArgsConstructor
@Getter
@Setter
public class City {
    public int id;
    public String name;
    public Commune commune;
}
