package pl.wolke.doghouse.dto;

import lombok.Data;
import pl.wolke.doghouse.config.security.User;
import pl.wolke.doghouse.entity.*;

import java.util.Set;

@Data
public class Purchase {

    private User user;
    private Address shippingAddress;
    private Address billingAddress;
    private Order order;
    private Set<OrderItem> orderItems;

}