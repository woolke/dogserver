package pl.wolke.doghouse.service;

import org.springframework.stereotype.Service;
import pl.wolke.doghouse.config.security.UserRepository;
import pl.wolke.doghouse.dto.Purchase;
import pl.wolke.doghouse.dto.PurchaseResponse;
import pl.wolke.doghouse.config.security.User;
import pl.wolke.doghouse.entity.Order;
import pl.wolke.doghouse.entity.OrderItem;

import javax.transaction.Transactional;
import java.util.Set;
import java.util.UUID;

@Service
public class CheckoutService {

    private UserRepository customerRepository;

    public CheckoutService(UserRepository customerRepository) {
        this.customerRepository = customerRepository;
    }

    @Transactional
    public PurchaseResponse placeOrder(Purchase purchase) {
        Order order = purchase.getOrder();
        String orderTrackingNumber = generateOrderTrackingNumber();
        order.setOrderTrackingNumber(orderTrackingNumber);
        Set<OrderItem> orderItems = purchase.getOrderItems();
        orderItems.forEach(order::add);
        order.setBillingAddress(purchase.getBillingAddress());
        order.setShippingAddress(purchase.getShippingAddress());

        User user = purchase.getUser();
        user.add(order);
        customerRepository.save(user);
        return new PurchaseResponse(orderTrackingNumber);
    }

    private String generateOrderTrackingNumber() {
        return UUID.randomUUID().toString();
    }
}
