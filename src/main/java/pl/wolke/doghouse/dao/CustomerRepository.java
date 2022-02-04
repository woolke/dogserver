package pl.wolke.doghouse.dao;

import org.springframework.data.jpa.repository.JpaRepository;
import pl.wolke.doghouse.entity.User;

public interface CustomerRepository extends JpaRepository<User, Long> {
}