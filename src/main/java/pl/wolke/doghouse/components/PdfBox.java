package pl.wolke.doghouse.components;

import org.apache.commons.lang3.StringUtils;;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.encryption.InvalidPasswordException;
import org.apache.pdfbox.pdmodel.interactive.form.PDField;
import org.apache.pdfbox.rendering.ImageType;
import org.apache.pdfbox.rendering.PDFRenderer;
import org.apache.pdfbox.text.PDFTextStripper;
import org.apache.pdfbox.text.PDFTextStripperByArea;
import org.imgscalr.Scalr;
import org.springframework.stereotype.Component;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;
import pl.wolke.doghouse.entity.Policy;
import pl.wolke.doghouse.utils.StaticFunc;


import javax.imageio.ImageIO;
import java.awt.geom.Rectangle2D;
import java.awt.image.BufferedImage;
import java.io.*;
import java.util.*;

import static pl.wolke.doghouse.utils.StaticFunc.bigDecimalFromString;
import static pl.wolke.doghouse.utils.StaticFunc.parseDateFromString;

@Component
public class PdfBox {


    public ArrayList<String> convertPdfToStringArray(InputStream pdfFile) {

        try (PDDocument document = PDDocument.load(pdfFile)) {
            if (!document.isEncrypted()) {
                PDFTextStripperByArea stripper = new PDFTextStripperByArea();
                stripper.setSortByPosition(true);
                PDFTextStripper tStripper = new PDFTextStripper();
                String pdfFileInText = tStripper.getText(document);
                String lines[] = pdfFileInText.split("\\r?\\n");
                ArrayList<String> pdfArrayLines = new ArrayList<>();
                Collections.addAll(pdfArrayLines, lines);
                pdfFile.close();
                return pdfArrayLines;
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }

    public static String convertPdfToString(InputStream pdfFile) {
        PDDocument document = null;
        try {
            document = PDDocument.load(pdfFile);
        } catch (Exception e) {
            try {
                document = PDDocument.load(pdfFile, "147478680");
            } catch (IOException e1) {
                try {
                    document = PDDocument.load(pdfFile, "273628971");
                } catch (IOException e2) {
                    e2.printStackTrace();
                    return null;
                }
            }
        }
        PDFTextStripperByArea stripper = null;
        try {
            stripper = new PDFTextStripperByArea();
            stripper.setSortByPosition(true);
            PDFTextStripper tStripper = new PDFTextStripper();
            return tStripper.getText(document);
        } catch (IOException e2) {
            return null;
        }
    }

    public static PDDocument createBlankPdf() {
        return new PDDocument();
    }

    public PDDocument addFirstPageToDocument(PDDocument pdfDocument, MultipartFile pdfWithFirtPageToAdd) throws IOException {
        InputStream inputStream = multipartToinputStream(pdfWithFirtPageToAdd);
        try (PDDocument document = PDDocument.load(inputStream)) {
            if (!document.isEncrypted()) {
                PDPage pageToAdd = document.getPage(0);
                pdfDocument.importPage(pageToAdd);
                pdfDocument.save(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

        return PDDocument.load(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
    }

    public PDDocument addOnePageToDocument(PDDocument target, MultipartFile source, Integer pageNumber) throws IOException {
        InputStream inputStream = multipartToinputStream(source);
        try (PDDocument document = PDDocument.load(inputStream)) {
            if (!document.isEncrypted()) {
                PDPage pageToAdd = document.getPage(pageNumber - 1);
                target.importPage(pageToAdd);
                target.save(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

        return PDDocument.load(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
    }

    public static File mergeFirstPagesToOneDocument(List<File> pdfWithFirtPageToAdd) throws IOException {

        PDDocument blankPdf = createBlankPdf();
        blankPdf.save(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
        blankPdf.close();
        for (File file : pdfWithFirtPageToAdd) {
            try {
                blankPdf = PDDocument.load(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
                InputStream inputStream = new FileInputStream(file);
                PDDocument document = PDDocument.load(inputStream);
                PDPage pageToAdd = document.getPage(0);
                blankPdf.importPage(pageToAdd);
                blankPdf.save(new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf"));
                blankPdf.close();
                System.out.println(file.getName());
            } catch (Exception e) {
                e.printStackTrace();
            }
        }


        return new File("D:/WIN/Aplikacja/drive/POLISY/PolisaTMP.pdf");
    }


    public static void update() throws InvalidPasswordException, IOException {
        Map<String, String> map = new HashMap<>();
        map.put("fieldname", "value to update");
        File template = new File("testPdf.pdf");
        PDDocument document = PDDocument.load(template);
        List<PDField> fields = document.getDocumentCatalog().getAcroForm().getFields();
        for (PDField field : fields) {
            for (Map.Entry<String, String> entry : map.entrySet()) {
                if (entry.getKey().equals(field.getFullyQualifiedName())) {
                    field.setValue(entry.getValue());
                    field.setReadOnly(true);
                }
            }
        }
        File out = new File("out.pdf");
        document.save(out);
        document.close();
    }

    public static String searchNumberCharThenSubstring(String string, String search, Integer numberOfChar, Integer gap) {
        String result = "";
        try {
            Integer startChar = string.indexOf(search) + gap;
            result = string.substring(startChar + search.length(), startChar + search.length() + numberOfChar);
        } catch (Exception e) {
        }
        return result;
    }


    public Policy processPoliciesPdf(@RequestParam("uploadingFiles") MultipartFile[] uploadingFiles, ArrayList<Policy> arrayList, Boolean override) {
        PDDocument returnPdf = createBlankPdf();
        for (MultipartFile uploadingFile : uploadingFiles) {
            try {
                InputStream inputStream = multipartToinputStream(uploadingFile);
                String stringpdf = convertPdfToString(inputStream);
                if (stringpdf.contains("Numer rachunku bankowego")
                        || stringpdf.contains("Składka została opłacona w całości")
                        || stringpdf.contains("TUiR WARTA S.A.")
                        || stringpdf.contains("AXA Ubezpieczenia TUiR S.A")
                        || stringpdf.contains("Polisa Compensa Komunikacja")) {
                    return getPolicyDtoFromString(stringpdf);
                }
            } catch (Exception e) {
            }
        }
        return null;
    }


    public static Policy getPolicy(@RequestParam("uploadingFiles") MultipartFile uploadingFile) {
        InputStream inputStream = multipartToinputStream(uploadingFile);
        String stringpdf = convertPdfToString(inputStream);
        if (stringpdf.contains("Numer rachunku bankowego")
                || stringpdf.contains("Składka została opłacona w całości")
                || stringpdf.contains("TUiR WARTA S.A.")
                || stringpdf.contains("AXA Ubezpieczenia TUiR S.A")
                || stringpdf.contains("Polisa Compensa Komunikacja")) {
            return getPolicyDtoFromString(stringpdf);
        }
        return new Policy();
    }


        private static Policy getPolicyDtoFromString (String stringpdf){
            Policy policy = Policy.builder().build();

            if (stringpdf.contains("PZU")) {
                policy.setFromDate(parseDateFromString(PdfBox.searchNumberCharThenSubstring
                        (stringpdf, "od ", 10, 0)));
                policy.setToDate(parseDateFromString(PdfBox.searchNumberCharThenSubstring
                        (stringpdf, "do ", 10, 0)));
                policy.setPaymentDate(parseDateFromString(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "Termin płatności ", "\r\n"))));
                policy.setPaymentValue(bigDecimalFromString(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Składka łączna: ", " zł"))));
                policy.setPaymentIban(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "Numer rachunku bankowego do zapłaty składki\r\n", "\r\n")));

                policy.setPolicyNr(PdfBox.searchNumberCharThenSubstring(stringpdf, "Nr ", 10, 0));
                policy.setCarName(StringUtils.substringBetween
                        (stringpdf, "Marka: ", "Typ:").replace("Model: ", ""));
                policy.setCarRej(StringUtils.substringBetween(stringpdf, "rejestracyjny ", "\r\nMarka: "));
                policy.setCarVin(StringUtils.deleteWhitespace
                        (StringUtils.substringBetween(stringpdf, "umer VIN/nadwozia/podwozia: ", " ")));
                if (stringpdf.contains("Składka została opłacona w całości")) {
                    policy.setPaidDate(new Date());
                    policy.setPaymentDate(new Date());
                    policy.setPaymentIban("Składka została opłacona ONLINE");
                }
            } else if (stringpdf.contains("Towarzystwo Ubezpieczeń i Reasekuracji")) {
                String printOc = StringUtils.substringBetween
                        (stringpdf, "POTWIERDZENIE ZAWARCIA OBOWIĄZKOWEGO UBEZPIECZENIA OC", "WNIOSEK - POLISA NR");
                policy.setFromDate(parseDateFromString(PdfBox.searchNumberCharThenSubstring
                        (printOc, "od: ", 10, 0)));
                policy.setToDate(parseDateFromString(PdfBox.searchNumberCharThenSubstring
                        (printOc, "do: ", 10, 0)));
                policy.setPaymentDate(parseDateFromString(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "Termin płatności :\r\nKwota :\r\n", "\r\n"))));
                policy.setPaymentValue(bigDecimalFromString(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(printOc, "Składka łączna: ", " zł"))));
                policy.setPaymentIban(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "konto TUiR \"WARTA\" S.A. numer : ", "\r\n")));
                policy.setPolicyNr(StringUtils.substringBetween(printOc, "NR POLISY: ", "\r\n"));
                policy.setCarName(StringUtils.substringBetween(printOc, "Marka, typ, model: ", "\r\n"));
                policy.setCarRej(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(printOc, "Numer rejestracyjny pojazdu: ", "\r\n")));
                policy.setCarVin(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(printOc, "Numer identyfikacyjny (VIN): ", "\r\n")));
            } else if (stringpdf.contains("TUiR WARTA S.A.")) {
                String datesFromToString = StringUtils.substringBetween
                        (stringpdf, "zł-", "\r\n");
                List<String> datesFromTo = StaticFunc.splitStringByCustomChar(datesFromToString, " ");
                policy.setFromDate(StaticFunc.parseDateFromString(datesFromTo.get(0)));
                policy.setToDate(StaticFunc.parseDateFromString(datesFromTo.get(datesFromTo.size() - 1)));

                policy.setPaymentDate(parseDateFromString(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "przelewem do dnia ", " na konto TUiR WARTA S.A. o numerze:"))));
                policy.setPaymentValue(StaticFunc.bigDecimalFromString(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Krótkoterminowe ", " "))));
                if (policy.getPaymentValue() == null || policy.getPaymentValue().intValue() == 0)
                    policy.setPaymentValue(StaticFunc.bigDecimalFromString(StringUtils.deleteWhitespace(
                            StringUtils.substringBetween(stringpdf, "I rata w kwocie ", " zł"))));
                if (policy.getPaymentValue() == null || policy.getPaymentValue().intValue() == 0)
                    policy.setPaymentValue(StaticFunc.bigDecimalFromString(StringUtils.deleteWhitespace(
                            StringUtils.substringBetween(stringpdf, "EUR**", "zł"))));

                policy.setPaymentIban(StringUtils.deleteWhitespace(StringUtils.substringBetween
                        (stringpdf, "o numerze:", ".")));
                policy.setPolicyNr(StringUtils.substringBetween(stringpdf, "WNIOSEK-POLISA NR:", "\r\n"));
                policy.setCarName(StringUtils.substringBetween(stringpdf, "Marka, Model, Typ: ", "\r\n"));
                policy.setCarRej(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Nr rejestracyjny: ", "\r\n")));
                policy.setCarVin(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Numer identyfikacyjny (VIN): ", "\r\n")));

            } else if (stringpdf.contains("Polisa Compensa Komunikacja")) {
                String fromTo = StringUtils.substringBetween(stringpdf, "numer", "okres ubezpieczeni");
                policy.setFromDate(StaticFunc.parseDateFromString(StringUtils.deleteWhitespace((PdfBox.searchNumberCharThenSubstring
                        (fromTo, ":", 12, 1)))));
                policy.setToDate(StaticFunc.parseDateFromString(StringUtils.deleteWhitespace((PdfBox.searchNumberCharThenSubstring
                        (fromTo, "-", 10, 1)))));

                String paymentDayAndValue = StringUtils.substringBetween(stringpdf, "I rata", "Tryb");
                policy.setPaymentDate(StaticFunc.parseDateFromString(StringUtils.deleteWhitespace((PdfBox.searchNumberCharThenSubstring
                        (paymentDayAndValue, " - ", 10, 1)))));
                policy.setPaymentValue(StaticFunc.bigDecimalFromString(StringUtils.substringBetween
                        (paymentDayAndValue.replaceFirst("-", ";"), "- ", " zł")));
                policy.setPaymentIban(StringUtils.substringBetween
                                (stringpdf, "Konto bankowe do płatności składek: ", "\r\n")
                        .replace(" ", ""));
                policy.setPolicyNr(StringUtils.substringBetween(stringpdf, "polisy: ", "numer:")
                        .replace(", ", ""));
                policy.setCarName(StringUtils.substringBetween(stringpdf, "Make:", "\r\n"));
                policy.setCarRej(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Numer rejestracyjny:", "\r\n")));
                policy.setCarVin(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "Numer VIN:", "\r\n")));
            } else if (stringpdf.contains("AXA Ubezpieczenia TUiR S.A")) {

                String fromTo = StringUtils.substringBetween(stringpdf, "Okres ochrony:\r\n", "\r\nSkładka");
                policy.setFromDate(StaticFunc.parseDateFromString(fromTo.substring(0, 10)));
                policy.setToDate(StaticFunc.parseDateFromString(StringUtils.substringAfter(fromTo, "- ")));

                policy.setPaymentDate(StaticFunc.parseDateFromString(StringUtils.substringBetween(StringUtils.substringBetween
                        (stringpdf, "Rata 1:", "Rata 2:"), "zł  ", "\r\n")));
                policy.setPaymentValue(StaticFunc.bigDecimalFromString(StringUtils.substringBetween(stringpdf, "Rata 1: ", " zł")));
                policy.setPaymentIban(StringUtils.deleteWhitespace(StringUtils.substringBetween
                                (stringpdf, "Nr konta bankowego:", "Ubezpieczający")
                        .replace(" ", "")));
                policy.setPolicyNr(StringUtils.substringBetween(stringpdf, "Numer polisy:\r\n", "\r\n"));
                policy.setCarName(StringUtils.substringBetween(stringpdf, "Dla samochodu:\r\n", "\r\n"));
                policy.setCarRej(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, ".pl\r\n", "\r\n")));
                policy.setCarVin(StringUtils.deleteWhitespace(
                        StringUtils.substringBetween(stringpdf, "VIN ", "\r\n")));
            }
            return policy;
        }

        public static byte[] getJpg (InputStream pdfFile, Integer width){
            try {
                PDDocument document = null;
                document = PDDocument.load(pdfFile);
                PDFRenderer pdfRenderer = new PDFRenderer(document);
                BufferedImage bim = null;
                bim = pdfRenderer.renderImageWithDPI(0, 150, ImageType.RGB);
                if (width != null)
                    bim = generateImageThumbnail(bim, width);
                ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
                ImageIO.write(bim, "jpg", byteArrayOutputStream);
                document.close();
                return byteArrayOutputStream.toByteArray();
            } catch (IOException e) {
                e.printStackTrace();
                return null;
            }
        }

        public static byte[] getJpg (MultipartFile pdfFile, Integer width){
            return getJpg(multipartToinputStream(pdfFile), width);
        }


        public static String ocrFragment (InputStream pdfFile,int documentWidth, int documentHeight, int x, int y,
        int width, int height){
            PDDocument document = null;
            try {
                document = PDDocument.load(pdfFile);
                float ratio = document.getPage(0).getMediaBox().getWidth() / documentWidth;
                Rectangle2D region = new Rectangle2D.Double(x * ratio, y * ratio, width * ratio, height * ratio);
                String regionName = "region";
                PDFTextStripperByArea stripper;

                stripper = new PDFTextStripperByArea();
                stripper.addRegion(regionName, region);
                stripper.extractRegions(document.getPage(0));
                document.close();
                return stripper.getTextForRegion(regionName);
            } catch (Exception e) {
                return "";
            }
        }

        public static String ocrFragment (MultipartFile pdfFile,int documentWidth, int documentHeight, int x, int y,
        int width, int height){
            return ocrFragment(multipartToinputStream(pdfFile), documentWidth, documentHeight, x, y, width, height);
        }

        public static InputStream multipartToinputStream (MultipartFile multipartFile){
            try {
                return multipartFile.getInputStream();
            } catch (IOException e) {
                return null;
            }
        }

        public static BufferedImage generateImageThumbnail (BufferedImage image, Integer width)throws IOException {
            try {
                int idealWidth = width;
                BufferedImage source = image;
                if (source == null) {
                    return null;
                }
                int imgHeight = source.getHeight();
                int imgWidth = source.getWidth();

                float scale = (float) imgWidth / idealWidth;
                int height = (int) (imgHeight / scale);

                BufferedImage rescaledImage = Scalr.resize(source, Scalr.Method.QUALITY,
                        Scalr.Mode.AUTOMATIC, idealWidth, height);
                return rescaledImage;
            } catch (Exception e) {
                return null;
            }
        }
    }