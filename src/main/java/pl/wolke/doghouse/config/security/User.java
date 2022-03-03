package pl.wolke.doghouse.config.security;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.*;
import pl.wolke.doghouse.dto.UserDto;
import pl.wolke.doghouse.entity.Order;

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Table(name = "users")
@Builder
@AllArgsConstructor
@NoArgsConstructor
@Setter
@Getter
@Entity
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String email;
    private String fullName;
    private String username;

    String password;
    String pin;
    String imei;

    Integer rejectLoginAttempts;
    Boolean isBlocked;

    @JsonIgnore
    @ManyToMany(fetch = FetchType.EAGER)
    private Set<Role> roles;

    @OneToMany(mappedBy = "manager", cascade = CascadeType.ALL)
    private Set<User> employes;

    @ManyToOne()
    private User manager;

    @OneToMany(mappedBy = "user", cascade = CascadeType.ALL)
    private Set<Order> orders = new HashSet<>();

    public User(UserDto dto) {
        this.username = dto.getUsername();
        this.id = dto.getId();
        this.email = dto.getEmail();
        this.fullName = dto.getFullName();
    }

    public boolean isManager() {
        return roles.stream().anyMatch(roles -> roles.getName().equals("MANAGER"));
    }

    public boolean isGuest() {
        return roles.stream().anyMatch(roles -> roles.getName().equals("GUEST"));
    }

    public void add(Order order) {
        if (order != null) {
            if (orders == null) {
                orders = new HashSet<>();
            }
            orders.add(order);
            order.setUser(this);
        }
    }

    public User getManager() {
        if (isManager())
            return this;
        else if (manager == null)
            return User.builder().build();
        else
            return this.manager;
    }

    public UserDto dto() {
        return UserDto.builder()
                .username(this.getUsername())
                .id(this.getId())
                .email(this.getEmail())
                .fullName(this.getFullName())
                .build();
    }
}
