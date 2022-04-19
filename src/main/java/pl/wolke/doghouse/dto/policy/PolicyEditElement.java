package pl.wolke.doghouse.dto.policy;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.Builder;
import lombok.Getter;
import lombok.Setter;
import org.springframework.web.multipart.MultipartFile;
import pl.wolke.doghouse.entity.Policy;

import java.util.HashMap;
import java.util.Map;

@Builder
@Getter
@Setter
public class PolicyEditElement {
    private static final Map<String, Map<String, PolicyEditElement>> editElements = new HashMap<>();
    private String uuid;
    @JsonIgnore
    private MultipartFile file;
    private byte[] jpgPreview;
    private PolicyDto policy;

    public  void addToCache(String userName){
        if (uuid!= null && file != null){
            Map<String, PolicyEditElement> cache = getCached(userName);
            cache.put(uuid, this);
            editElements.put(userName, cache);
        }
    }

    public static Map<String, PolicyEditElement> getCached(String userName) {
        if (editElements.containsKey(userName))
            return editElements.get(userName);
        else
            return new HashMap<>();
    }


    public static PolicyEditElement getCached(String userName, String uuid) {
        if (editElements.containsKey(userName))
            return editElements.get(userName).get(uuid);
        else
            return null;
    }
}
