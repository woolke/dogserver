package pl.wolke.doghouse.dto.policy;

import lombok.*;

import java.math.BigDecimal;

import static pl.wolke.doghouse.utils.StaticFunc.getRRRR_MM_DD_String;


@Builder
@AllArgsConstructor
@NoArgsConstructor
@Setter
@Getter
public class PolicyDto {
    Integer id;
    String fromDate;
    String toDate;
    String paymentDate;
    String paidDate;
    String policyNr;
    String carName;
    String carRej;
    String carVin;
    String paymentIban;
    BigDecimal paymentValue;
    BigDecimal toSettlementValue;
    Boolean toSettlement;
    String pdfPath;
    String confirmPayPdf;
    String comment;
}
