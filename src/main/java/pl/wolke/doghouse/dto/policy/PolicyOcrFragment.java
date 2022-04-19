package pl.wolke.doghouse.dto.policy;

import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class PolicyOcrFragment {
    String uuid;
    int x;
    int y;
    int width;
    int height;

    int previewH;
    int previewW;

    String text;


}
