package pl.wolke.doghouse.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import pl.wolke.doghouse.dao.ProductRepository;
import pl.wolke.doghouse.entity.Product;

import java.util.HashMap;
import java.util.Map;

@CrossOrigin("http://localhost:4200")
@RestController
@RequestMapping("/test")
public class TestController {

    private final ProductRepository productRepository;

    @Autowired
    public TestController(ProductRepository productRepository) {
        this.productRepository = productRepository;
    }

    @GetMapping("/productsByCategory")
    public ResponseEntity<Map<String, Object>> getAllTutorials(
            @RequestParam(required = false) String title,
            @RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "3") int size,
            @RequestParam(defaultValue = "1") int category) {

        Pageable paging = PageRequest.of(page, size);

        Page<Product> byCategoryId = productRepository.findByCategoryId(Long.valueOf(category), null);

        Map<String, Object> response = new HashMap<>();
        response.put("tutorials", byCategoryId.getContent());
        response.put("currentPage", byCategoryId.getNumber());
        response.put("totalItems", byCategoryId.getTotalElements());
        response.put("totalPages", byCategoryId.getTotalPages());

        return new ResponseEntity<>(response, HttpStatus.OK);
    }
}
