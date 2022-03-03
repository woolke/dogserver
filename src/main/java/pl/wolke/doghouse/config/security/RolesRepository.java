package pl.wolke.doghouse.config.security;

import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface RolesRepository extends JpaRepository<Role, Long> {
}