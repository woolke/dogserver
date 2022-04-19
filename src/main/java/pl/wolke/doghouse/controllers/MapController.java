package pl.wolke.doghouse.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import pl.wolke.doghouse.dto.map.Station;
import pl.wolke.doghouse.service.MapService;

@CrossOrigin(origins = "*", maxAge = 3600)
@RestController
@RequestMapping("/api/map")
public class MapController {

	public final MapService mapService;

	@Autowired
	public MapController(MapService mapService) {
		this.mapService = mapService;
	}

	@GetMapping("/findAll")
	public ResponseEntity<Station[]> findAll() {
		return ResponseEntity.ok(mapService.findAllStation());
	}
}
