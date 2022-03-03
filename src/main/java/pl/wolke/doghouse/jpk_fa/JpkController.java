package pl.wolke.doghouse.jpk_fa;

import jakarta.xml.bind.annotation.XmlAnyElement;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import pl.wolke.doghouse.jpk_fa._v3.fa.*;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBElement;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.namespace.QName;
import java.io.StringWriter;
import java.math.BigDecimal;
import java.math.BigInteger;
import java.text.SimpleDateFormat;
import java.util.*;

@RestController
@RequestMapping("/api/jpk")
public class JpkController {
    private static SimpleDateFormat dateTimeSdf = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss");
    private static SimpleDateFormat dateSdf = new SimpleDateFormat("yyyy-MM-dd");

    @RequestMapping(value = "/sampleJpkFa", method = RequestMethod.GET, produces = MediaType.APPLICATION_XML_VALUE)
    public @ResponseBody
    String sample() throws JAXBException {
        JPK jpk = new JPK();
        setNaglowek(jpk);
        setPodmiotWk(jpk);
        setInvoicesListWk(jpk);
        setInvoicesRowWk(jpk);
        String xml = marshal(jpk);
        return xml;
    }

    private void setNaglowek(JPK jpk) {
        JPK.Naglowek naglowek = new JPK.Naglowek();
        TNaglowek.KodFormularza kodFormularza = new TNaglowek.KodFormularza();
        kodFormularza.setKodSystemowy("JPK_FA (3)");
        kodFormularza.setWersjaSchemy("1-0");
        naglowek.setKodFormularza(kodFormularza);
        naglowek.setWariantFormularza((byte) 3);
        naglowek.setCelZlozenia((byte) 1);
        naglowek.setDataWytworzeniaJPK(getXmlDate(new Date(), dateTimeSdf));
        naglowek.setDataOd(getMonthFirstDay(new Date(), dateSdf));
        naglowek.setDataDo(getMonthLastDay(new Date(), dateSdf));
        naglowek.setKodUrzedu("2413");
        jpk.setNaglowek(naglowek);
    }

    private void setPodmiotAw(JPK jpk) {
        JPK.Podmiot1 podmiot = new JPK.Podmiot1();
        TIdentyfikatorOsobyNiefizycznej1 identyfikatorPodmiotu = new TIdentyfikatorOsobyNiefizycznej1();
        identyfikatorPodmiotu.setNIP("9691610495");
        identyfikatorPodmiotu.setPelnaNazwa("Anna Wolke 'Zamiokulkas'");
        podmiot.setIdentyfikatorPodmiotu(identyfikatorPodmiotu);
        TAdresPolski1 adresPodmiotu = new TAdresPolski1();
        adresPodmiotu.setKodKraju(TKodKraju.PL);
        adresPodmiotu.setWojewodztwo("Śląskie");
        adresPodmiotu.setPowiat("Gliwicki");
        adresPodmiotu.setGmina("Sośnicowice");
        adresPodmiotu.setMiejscowosc("Sośnicowice");
        adresPodmiotu.setUlica("Raciborska");
        adresPodmiotu.setNrDomu("77");
        adresPodmiotu.setKodPocztowy("44-153");
        jpk.setPodmiot1(podmiot);
    }

    private void setPodmiotWk(JPK jpk) {
        JPK.Podmiot1 podmiot = new JPK.Podmiot1();
        TIdentyfikatorOsobyNiefizycznej1 identyfikatorPodmiotu = new TIdentyfikatorOsobyNiefizycznej1();
        identyfikatorPodmiotu.setNIP("6311422640");
        identyfikatorPodmiotu.setPelnaNazwa("WIN Waldemar Krupa");
        podmiot.setIdentyfikatorPodmiotu(identyfikatorPodmiotu);
        TAdresPolski1 adresPodmiotu = new TAdresPolski1();
        adresPodmiotu.setKodKraju(TKodKraju.PL);
        adresPodmiotu.setWojewodztwo("Śląskie");
        adresPodmiotu.setPowiat("Gliwice");
        adresPodmiotu.setGmina("Gliwice");
        adresPodmiotu.setMiejscowosc("Gliwice");
        adresPodmiotu.setUlica("Lipowa");
        adresPodmiotu.setNrDomu("12");
        adresPodmiotu.setKodPocztowy("44-100");
        podmiot.setAdresPodmiotu(adresPodmiotu);
        jpk.setPodmiot1(podmiot);
    }

    private void setInvoicesListWk(JPK jpk) {
        JPK.Faktura faktura = new JPK.Faktura();
        faktura.setKodWaluty(CurrCodeType.PLN);
        faktura.setRodzajFaktury("VAT");
        faktura.setP1(getXmlDate(new Date(), dateSdf));
        faktura.setP2A("3/2/2022");
        faktura.setP3C("Waldemar Krupa");
        faktura.setP3D("44-100 Gliwice, ul Lipowa 14");
        faktura.setP4A(MSCountryCodeType.PL);
        faktura.setP4B("5213568112");
        faktura.setP5B("5213568112");
        faktura.setP131(new BigDecimal("1500"));
        faktura.setP141(new BigDecimal("345"));
        faktura.setP15(new BigDecimal("1845"));
        faktura.setP16(false);
        faktura.setP17(false);
        faktura.setP18(false);
        faktura.setP19(false);
        faktura.setP20(false);
        faktura.setP21(false);
        faktura.setP22(false);
        faktura.setP23(false);
        faktura.setP20(false);
        faktura.setP106E2(false);
        faktura.setP106E3(false);
        jpk.getFaktura().add(faktura);

        JPK.FakturaCtrl fakturaCtrl = new JPK.FakturaCtrl();
        fakturaCtrl.setLiczbaFaktur(BigInteger.ONE);
        fakturaCtrl.setWartoscFaktur(new BigDecimal("1845"));

    }

    private void setInvoicesRowWk(JPK jpk) {
        JPK.FakturaWiersz wiersz = new JPK.FakturaWiersz();
        wiersz.setP2B("3/2/2022");
        wiersz.setP7("Kwota stała (LUTY 2022)");
        wiersz.setP8A("m-c");
        wiersz.setP8B(BigDecimal.ONE);
        wiersz.setP9A(new BigDecimal("1500"));
        wiersz.setP9B(new BigDecimal("1835"));
        wiersz.setP11(new BigDecimal("1500"));
        wiersz.setP11A(new BigDecimal("1835"));
        jpk.getFakturaWiersz().add(wiersz);

        JPK.FakturaWierszCtrl fakturaCtrl = new JPK.FakturaWierszCtrl();
        fakturaCtrl.setLiczbaWierszyFaktur(BigInteger.ONE);
        fakturaCtrl.setWartoscWierszyFaktur(new BigDecimal("1845"));
    }

    private static XMLGregorianCalendar getXmlDate(int year, int month, int day, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.set(Calendar.YEAR, year);
        c.set(Calendar.MONTH, month);
        c.set(Calendar.DAY_OF_MONTH, day);
        return getXmlDate(c.getTime(), sdf);
    }

    private static XMLGregorianCalendar getMonthFirstDay(int year, int month, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.set(Calendar.YEAR, year);
        c.set(Calendar.MONTH, month);
        c.set(Calendar.DAY_OF_MONTH, 1);
        try {
            return DatatypeFactory.newInstance().newXMLGregorianCalendar(sdf.format(c.getTime()));
        } catch (DatatypeConfigurationException e) {
            e.printStackTrace();
            return null;
        }
    }

    private static XMLGregorianCalendar getMonthLastDay(int year, int month, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.set(Calendar.YEAR, year);
        c.set(Calendar.MONTH, month);
        c.set(Calendar.DAY_OF_MONTH, 1);
        c.set(Calendar.DAY_OF_MONTH, c.getActualMaximum(Calendar.DAY_OF_MONTH));
        try {
            return DatatypeFactory.newInstance().newXMLGregorianCalendar(sdf.format(c.getTime()));
        } catch (DatatypeConfigurationException e) {
            e.printStackTrace();
            return null;
        }
    }

    private static XMLGregorianCalendar getXmlDate(Date date, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.setTime(date);
        try {
            return DatatypeFactory.newInstance().newXMLGregorianCalendar(sdf.format(c.getTime()));
        } catch (DatatypeConfigurationException e) {
            e.printStackTrace();
            return null;
        }
    }

    private static XMLGregorianCalendar getMonthFirstDay(Date date, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.setTime(date);
        return getMonthFirstDay(c.get(Calendar.YEAR), c.get(Calendar.MONTH), sdf);
    }

    private static XMLGregorianCalendar getMonthLastDay(Date date, SimpleDateFormat sdf) {
        GregorianCalendar c = new GregorianCalendar();
        c.setTime(date);
        return getMonthLastDay(c.get(Calendar.YEAR), c.get(Calendar.MONTH), sdf);
    }

    private static String marshal(JPK jpk) throws JAXBException {
        StringWriter stringWriter = new StringWriter();
        JAXBContext jc = JAXBContext.newInstance(JPK.class, JPK.Faktura.class, JPK.FakturaWiersz.class);
        JAXBContext jaxbContext = JAXBContext.newInstance(JPK.class, JPK.Faktura.class, JPK.FakturaWiersz.class);
        Marshaller jaxbMarshaller = jaxbContext.createMarshaller();
        jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT,
                true);
        QName qName = new QName("http://jpk.mf.gov.pl/wzor/2019/09/27/09271/", "JPK", "tns");
        JAXBElement<JPK> root = new JAXBElement<>(qName, JPK.class, jpk);

        jaxbMarshaller.marshal(root, stringWriter);

        String result = stringWriter.toString();

        result = result.replace("standalone=\"yes\"", "standalone=\"no\"");
        result = result.replace("<tns:JPK xmlns:tns=\"http://jpk.mf.gov.pl/wzor/2019/09/27/09271/\">",
                "<tns:JPK xmlns:etd=\"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/\" xmlns:kck=\"http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2013/05/23/eD/KodyCECHKRAJOW/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:tns=\"http://jpk.mf.gov.pl/wzor/2019/09/27/09271/\">");
        result = result.replaceAll("<", "<tns:");
        result = result.replaceAll("<tns:/", "</tns:");

        result = result.replaceAll("<tns:gmina", "<etd:gmina>");
        result = result.replaceAll("<tns:kodKraju", "<etd:kodKraju>");
        result = result.replaceAll("<tns:kodPocztowy", "<etd:kodPocztowy>");
        result = result.replaceAll("<tns:miejscowosc", "<etd:miejscowosc>");
        result = result.replaceAll("<tns:nrDomu", "<etd:nrDomu>");
        result = result.replaceAll("<tns:nrMieszkania", "<etd:nrMieszkania>");
        result = result.replaceAll("<tns:powiat", "<etd:powiat>");
        result = result.replaceAll("<tns:ulica", "<etd:ulica>");
        result = result.replaceAll("<tns:wojewodztwo", "<etd:wojewodztwo>");
        result = result.replaceAll("</tns:gmina", "</etd:gmina>");
        result = result.replaceAll("</tns:kodKraju", "</etd:kodKraju>");
        result = result.replaceAll("</tns:kodPocztowy", "</etd:kodPocztowy>");
        result = result.replaceAll("</tns:miejscowosc", "</etd:miejscowosc>");
        result = result.replaceAll("</tns:nrDomu", "</etd:nrDomu>");
        result = result.replaceAll("</tns:nrMieszkania", "</etd:nrMieszkania>");
        result = result.replaceAll("</tns:powiat", "</etd:powiat>");
        result = result.replaceAll("</tns:ulica", "</etd:ulica>");
        result = result.replaceAll("</tns:wojewodztwo", "</etd:wojewodztwo>");

        System.out.println(result);
        return result;
    }
}