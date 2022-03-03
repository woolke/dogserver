package pl.wolke.doghouse.config.security;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.web.bind.annotation.*;
import pl.wolke.doghouse.config.security.jwt.JwtUtils;
import pl.wolke.doghouse.config.security.payload.request.LoginRequest;
import pl.wolke.doghouse.config.security.payload.request.SignupRequest;
import pl.wolke.doghouse.config.security.payload.response.JwtResponse;
import pl.wolke.doghouse.config.security.payload.response.MessageResponse;

import javax.validation.Valid;
import java.util.List;
import java.util.stream.Collectors;

@CrossOrigin(origins = "*", maxAge = 3600)
@RestController
@RequestMapping("/api/auth")
public class AuthController {
	@Autowired
	AuthenticationManager authenticationManager;

	@Autowired
	UserRepository userRepository;

	@Autowired
	RolesRepository roleRepository;

	@Autowired
	PasswordEncoder encoder;

	@Autowired
	JwtUtils jwtUtils;

	@PostMapping("/signin")
	public ResponseEntity<?> authenticateUser(@Valid @RequestBody LoginRequest loginRequest) {

		Authentication authentication = authenticationManager.authenticate(
				new UsernamePasswordAuthenticationToken(loginRequest.getUsername(), loginRequest.getPassword()));

		SecurityContextHolder.getContext().setAuthentication(authentication);
		String jwt = jwtUtils.generateJwtToken(authentication);

		org.springframework.security.core.userdetails.User userDetails
				= (org.springframework.security.core.userdetails.User) authentication.getPrincipal();
		User byUsername = userRepository.findByUsername(userDetails.getUsername());
		List<String> roles = userDetails.getAuthorities().stream()
				.map(item -> item.getAuthority())
				.collect(Collectors.toList());

		return ResponseEntity.ok(new JwtResponse(jwt,byUsername));
	}

	@PostMapping("/signup")
	public ResponseEntity<?> registerUser(@Valid @RequestBody SignupRequest signUpRequest) {
		if (userRepository.existsByUsername(signUpRequest.getUsername())) {
			return ResponseEntity
					.badRequest()
					.body(new MessageResponse("Błąd: Nazwa użytkownika już istnieje!"));
		}

		if (userRepository.existsByEmail(signUpRequest.getEmail())) {
			return ResponseEntity
					.badRequest()
					.body(new MessageResponse("Błąd: Email w użyciu!"));
		}

		User user = User.builder().username(signUpRequest.getUsername())
				.email(signUpRequest.getEmail())
				.password(encoder.encode(signUpRequest.getPassword())).build();
		userRepository.save(user);
		return ResponseEntity.ok(new MessageResponse("Poprawnie zarejestrowany użytkownik! "));
	}
}
