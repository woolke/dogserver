package pl.wolke.doghouse.service;

import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpMethod;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.multipart.MultipartFile;
import pl.wolke.doghouse.components.PdfBox;
import pl.wolke.doghouse.dto.map.Station;
import pl.wolke.doghouse.entity.Policy;

import java.util.Objects;

@Service
public class PolicyServices {
    private final PdfBox pdfBox;

    public PolicyServices(PdfBox pdfBox) {
        this.pdfBox = pdfBox;
    }

    public byte[] getJpgPreview(MultipartFile pdfFile, Integer width) {
        return PdfBox.getJpg(pdfFile, width);
    }

    public Policy getPolicyFromPdf(MultipartFile pdfFile){
        return PdfBox.getPolicy(pdfFile);
    }

}
