package pl.wolke.doghouse.config.security;

import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface UserRepository extends JpaRepository<User, Long> {
    User findByUsername(String username);
    User findByFullName(String fullName);
    List<User> findAllByOrderByIdAsc();
    List<User> findAllByRoles_Name(String string);
    Boolean existsByUsername(String username);
    Boolean existsByEmail(String email);
    User findByImei(String imei);

}