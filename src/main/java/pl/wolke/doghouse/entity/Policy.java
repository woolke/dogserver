package pl.wolke.doghouse.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.*;
import pl.wolke.doghouse.dto.policy.PolicyDto;
import pl.wolke.doghouse.utils.StaticFunc;

import javax.persistence.*;
import java.math.BigDecimal;
import java.text.SimpleDateFormat;
import java.util.Date;

import static pl.wolke.doghouse.utils.StaticFunc.*;


@Builder
@AllArgsConstructor
@NoArgsConstructor
@Setter
@Getter
@Entity
@Table(name = "policies")
public class Policy {
    @Id
    @JsonIgnore
    @GeneratedValue (strategy = GenerationType.IDENTITY)
    Integer id;


    @JsonIgnore
    @Temporal(TemporalType.DATE)
    Date fromDate;

    @JsonIgnore
    @Temporal(TemporalType.DATE)
    Date toDate;

    @JsonIgnore
    @Temporal(TemporalType.DATE)
    Date paymentDate;

    @JsonIgnore
    @Temporal(TemporalType.DATE)
    Date paidDate;


    String policyNr;
    String carName;
    String carRej;
    String carVin;
    String paymentIban;
    @JsonIgnore
    BigDecimal paymentValue;
    @JsonIgnore
    BigDecimal toSettlementValue;
    @JsonIgnore
    Boolean toSettlement;
    String pdfPath;
    String confirmPayPdf;
    String comment;

    public static SimpleDateFormat sdfDay = new SimpleDateFormat("yyyy-MM-dd");

    public PolicyDto dto(){
        return PolicyDto.builder()
                .id(this.id)
                .fromDate(getRRRR_MM_DD_String(this.fromDate))
                .toDate(getRRRR_MM_DD_String(this.toDate))
                .paymentDate(getRRRR_MM_DD_String(this.paymentDate))
                .paidDate(getRRRR_MM_DD_String(this.paidDate))
                .policyNr(this.policyNr)
                .carName(this.carName)
                .carRej(this.carRej)
                .carVin(this.carVin)
                .paymentIban(this.paymentIban)
                .paymentValue(this.paymentValue)
                .toSettlementValue(this.toSettlementValue)
                .toSettlement(this.toSettlement)
                .pdfPath(this.pdfPath)
                .confirmPayPdf(this.confirmPayPdf)
                .comment(this.comment).build();
    }

    public Policy (PolicyDto dto){
                this.id = dto.getId();
                this.policyNr = dto.getPolicyNr();
                this.carName = dto.getCarName();
                this.carRej = dto.getCarRej();
                this.carVin = dto.getCarVin();
                this.paymentIban = dto.getPaymentIban();
                this.paymentValue = dto.getPaymentValue();
                this.toSettlementValue = dto.getToSettlementValue();
                this.toSettlement = dto.getToSettlement();
                this.pdfPath = dto.getPdfPath();
                this.confirmPayPdf = dto.getConfirmPayPdf();
                this.comment = dto.getComment();
                this.fromDate = parseDateFromString(dto.getFromDate(), sdfDay);
                this.toDate = parseDateFromString(dto.getToDate(), sdfDay);
                this.paymentDate = parseDateFromString(dto.getPaymentDate(), sdfDay);
                this.paidDate = parseDateFromString(dto.getPaidDate(), sdfDay);
    }

    @Override
    public String toString() {
        return "Polisa do;" + getRRRR_MM_DD_String(getToDate())+ ", od;" + getRRRR_MM_DD_String(getFromDate())
                + " (" + getCarRej()+ ") " + getCarName()+ "_" + getPolicyNr();
    }

    public String shortPrint() {
        return "Polisa do;" + getRRRR_MM_DD_String(getToDate())+ ":" + getPaymentValue()
                + "zł (" + getCarRej()+ ") " + getPolicyNr();
    }

    public String generateFileName() {
            return removeIllegalPathCharacter("Polisa do;" + getRRRR_MM_DD_String(getToDate())+ ", od;" + getRRRR_MM_DD_String(getFromDate())+ " (" + getCarRej()+ ") " + getCarName()+ "_" + getPolicyNr()+ ".pdf");
        }
}
