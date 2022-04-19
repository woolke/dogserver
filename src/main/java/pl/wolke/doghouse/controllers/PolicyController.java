package pl.wolke.doghouse.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.multipart.support.StandardMultipartHttpServletRequest;
import pl.wolke.doghouse.components.PdfBox;
import pl.wolke.doghouse.config.security.UserServiceImpl;
import pl.wolke.doghouse.dto.policy.PolicyEditElement;
import pl.wolke.doghouse.dto.policy.PolicyOcrFragment;
import pl.wolke.doghouse.service.PolicyServices;

import java.util.Map;

@CrossOrigin(origins = "*", maxAge = 3600)
@RestController
@RequestMapping("/api/policy")
public class PolicyController {



	public final PolicyServices policyService;

	@Autowired
	public PolicyController(PolicyServices policyService) {
		this.policyService = policyService;
	}

	@ResponseBody
	@RequestMapping(value = "/createPreview", produces = MediaType.APPLICATION_JSON_VALUE)
	public ResponseEntity<PolicyEditElement> createPreview(StandardMultipartHttpServletRequest request) {
		Map<String, String[]> parameterMap = request.getParameterMap();
		MultipartFile file = request.getMultiFileMap().get("file").get(0);
		String uuid = parameterMap.get("uuid")[0];
		Integer width = Integer.valueOf(parameterMap.get("width")[0]);
		byte[] files = policyService.getJpgPreview(file, width);
		PolicyEditElement policyEditElement = PolicyEditElement.builder()
				.uuid(uuid)
				.file(file)
				.jpgPreview(files)
				.policy(policyService.getPolicyFromPdf(file).dto()).build();
		policyEditElement.addToCache(request.getUserPrincipal().getName());
		return ResponseEntity.ok(policyEditElement);
	}

	@PostMapping("/ocrFragment")
	public ResponseEntity<PolicyOcrFragment> ocrFragment(@RequestBody PolicyOcrFragment fragment) {
		PolicyEditElement element = PolicyEditElement.getCached(UserServiceImpl.getUserName(), fragment.getUuid());

		String text = PdfBox.ocrFragment(
				element.getFile(), fragment.getPreviewW(), fragment.getPreviewH(), fragment.getX(), fragment.getY(), fragment.getWidth(), fragment.getHeight()
		);
		fragment.setText(text);
		return ResponseEntity.ok(fragment);
	}
}
