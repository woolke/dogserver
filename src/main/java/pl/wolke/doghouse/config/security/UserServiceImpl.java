package pl.wolke.doghouse.config.security;


import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.env.Environment;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.web.context.request.RequestContextHolder;
import org.springframework.web.context.request.ServletRequestAttributes;

import javax.servlet.http.HttpSession;
import javax.transaction.Transactional;
import java.util.*;
import java.util.stream.Collectors;


@Service
public class UserServiceImpl implements UserDetailsService {
    private static Logger LOG = LoggerFactory.getLogger(UserServiceImpl.class);

    @Autowired
    public Environment env;

    @Autowired
    private BCryptPasswordEncoder bCryptPasswordEncoder;

    @Autowired
    private final UserRepository userRepository;

    public UserServiceImpl(UserRepository userRepository) {
        this.userRepository = userRepository;
    }


    @Override
    @Transactional()
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        boolean byPin = username.startsWith("byPin");
        if (byPin)
            username = username.substring(5);
        User user = userRepository.findByUsername(username);
        HttpSession session = ((ServletRequestAttributes) RequestContextHolder.currentRequestAttributes())
                .getRequest().getSession();
        session.setAttribute("user", username);
        if (user == null) {
            throw new UsernameNotFoundException("Username is not in database");
        }
        if (Objects.equals(user.getIsBlocked(), true)) {
            throw new UsernameNotFoundException("Username is Blocked");
        }

        Set<GrantedAuthority> grantedAuthorities =
                user.getRoles().stream()
                        .map(r -> new SimpleGrantedAuthority("ROLE_" + r.getName()))
                        .collect(Collectors.toSet());
        String password = user.getPassword();
        if (byPin)
            password =  user.getPin();
        org.springframework.security.core.userdetails.User springUser =
                new org.springframework.security.core.userdetails.User(
                user.getUsername(), password, grantedAuthorities);
        return springUser;
    }

    public User save(User user, boolean decryptPassword) {
        if (getLoggedInUser().isManager()) {
            if (decryptPassword){
                user.setPassword(bCryptPasswordEncoder.encode(user.getPassword()));
            }
            return userRepository.save(user);
        }
        return null;
    }

    public Iterable getAllUsersNamesAndTheirRoles() {
        return userRepository.findAll().stream().map(user -> {
            User tmpUser = new User();
            tmpUser.setUsername(user.getUsername());
            tmpUser.setRoles(user.getRoles());
            return tmpUser;
        }).collect(Collectors.toList());
    }


    public User getLoggedInUser() {
        Optional<User> user = null;
        try {
            User principal = (User) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
            user = Optional.ofNullable(userRepository.findByUsername(principal.getUsername()));
            return user.get();
        } catch (Exception e) {
            user = Optional.ofNullable(userRepository.findByUsername("guest"));
            return user.orElse(null);
        }
    }

    public void changeUserPassword(String username, String password) {
        User loggedInUser = getLoggedInUser();
        if (loggedInUser.isManager()) {
            User user = userRepository.findByUsername(username);
            user.setPassword(bCryptPasswordEncoder.encode(password));
            userRepository.save(user);
        } else if (loggedInUser.getUsername().equals(username)) {
            loggedInUser.setPassword(bCryptPasswordEncoder.encode(password));
            userRepository.save(loggedInUser);
        }
    }

    public List<User> getAll() {
        if (getLoggedInUser().isManager()) {
            return userRepository.findAll();
        } else {
            List<User> users = new ArrayList<>();
            users.add(getLoggedInUser());
            return users;
        }
    }

    public User getVindicatorByFullName(String fullName) {
        return userRepository.findByFullName(fullName);
    }

    public User getVindicatorByUsername(String username) {
        return userRepository.findByUsername(username);
    }



}