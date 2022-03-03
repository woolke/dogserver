//
// This file was generated by the Eclipse Implementation of JAXB, v3.0.2 
// See https://eclipse-ee4j.github.io/jaxb-ri 
// Any modifications to this file will be lost upon recompilation of the source schema. 
// Generated on: 2022.02.19 at 01:15:10 PM CET 
//


package pl.wolke.doghouse.jpk_fa._v3.fa;

import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlSchemaType;
import jakarta.xml.bind.annotation.XmlType;
import jakarta.xml.bind.annotation.adapters.CollapsedStringAdapter;
import jakarta.xml.bind.annotation.adapters.XmlJavaTypeAdapter;


/**
 * Informacje opisujące adres zagraniczny
 * 
 * <p>Java class for TAdresZagraniczny complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="TAdresZagraniczny"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="KodKraju"&gt;
 *           &lt;simpleType&gt;
 *             &lt;restriction base="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TKodKraju"&gt;
 *               &lt;pattern value="P[A-KM-Z]"/&gt;
 *               &lt;pattern value="[A-OQ-Z][A-Z]"/&gt;
 *             &lt;/restriction&gt;
 *           &lt;/simpleType&gt;
 *         &lt;/element&gt;
 *         &lt;element name="KodPocztowy" type="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TKodPocztowy" minOccurs="0"/&gt;
 *         &lt;element name="Miejscowosc" type="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TMiejscowosc"/&gt;
 *         &lt;element name="Ulica" type="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TUlica" minOccurs="0"/&gt;
 *         &lt;element name="NrDomu" type="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TNrBudynku" minOccurs="0"/&gt;
 *         &lt;element name="NrLokalu" type="{http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/}TNrLokalu" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "TAdresZagraniczny", propOrder = {
    "kodKraju",
    "kodPocztowy",
    "miejscowosc",
    "ulica",
    "nrDomu",
    "nrLokalu"
})
public class TAdresZagraniczny {

    @XmlElement(name = "KodKraju", required = true)
    protected TKodKraju kodKraju;
    @XmlElement(name = "KodPocztowy")
    @XmlJavaTypeAdapter(CollapsedStringAdapter.class)
    @XmlSchemaType(name = "token")
    protected String kodPocztowy;
    @XmlElement(name = "Miejscowosc", required = true)
    @XmlJavaTypeAdapter(CollapsedStringAdapter.class)
    @XmlSchemaType(name = "token")
    protected String miejscowosc;
    @XmlElement(name = "Ulica")
    @XmlJavaTypeAdapter(CollapsedStringAdapter.class)
    @XmlSchemaType(name = "token")
    protected String ulica;
    @XmlElement(name = "NrDomu")
    @XmlJavaTypeAdapter(CollapsedStringAdapter.class)
    @XmlSchemaType(name = "token")
    protected String nrDomu;
    @XmlElement(name = "NrLokalu")
    @XmlJavaTypeAdapter(CollapsedStringAdapter.class)
    @XmlSchemaType(name = "token")
    protected String nrLokalu;

    /**
     * Gets the value of the kodKraju property.
     * 
     * @return
     *     possible object is
     *     {@link TKodKraju }
     *     
     */
    public TKodKraju getKodKraju() {
        return kodKraju;
    }

    /**
     * Sets the value of the kodKraju property.
     * 
     * @param value
     *     allowed object is
     *     {@link TKodKraju }
     *     
     */
    public void setKodKraju(TKodKraju value) {
        this.kodKraju = value;
    }

    /**
     * Gets the value of the kodPocztowy property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKodPocztowy() {
        return kodPocztowy;
    }

    /**
     * Sets the value of the kodPocztowy property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKodPocztowy(String value) {
        this.kodPocztowy = value;
    }

    /**
     * Gets the value of the miejscowosc property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMiejscowosc() {
        return miejscowosc;
    }

    /**
     * Sets the value of the miejscowosc property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMiejscowosc(String value) {
        this.miejscowosc = value;
    }

    /**
     * Gets the value of the ulica property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUlica() {
        return ulica;
    }

    /**
     * Sets the value of the ulica property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUlica(String value) {
        this.ulica = value;
    }

    /**
     * Gets the value of the nrDomu property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNrDomu() {
        return nrDomu;
    }

    /**
     * Sets the value of the nrDomu property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNrDomu(String value) {
        this.nrDomu = value;
    }

    /**
     * Gets the value of the nrLokalu property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNrLokalu() {
        return nrLokalu;
    }

    /**
     * Sets the value of the nrLokalu property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNrLokalu(String value) {
        this.nrLokalu = value;
    }

}
