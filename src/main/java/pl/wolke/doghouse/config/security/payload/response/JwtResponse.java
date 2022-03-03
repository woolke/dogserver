package pl.wolke.doghouse.config.security.payload.response;

import lombok.Getter;
import lombok.Setter;
import pl.wolke.doghouse.config.security.Role;
import pl.wolke.doghouse.config.security.User;
import pl.wolke.doghouse.dto.UserDto;

import java.util.Set;
import java.util.stream.Collectors;

@Getter
@Setter
public class JwtResponse {
	private UserDto user;
	private UserDto manager;
	private String token;
	private String type = "Bearer";
	private Set<String> roles;

	public JwtResponse(String accessToken, User user) {
		this.token = accessToken;
		this.user = user.dto();
		this.manager = user.getManager().dto();
		this.roles = user.getRoles().stream().map(Role::getName).collect(Collectors.toSet());
	}
}


