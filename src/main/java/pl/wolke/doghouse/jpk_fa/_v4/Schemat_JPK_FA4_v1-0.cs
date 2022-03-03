///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 19.0.14                                   //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = True
// RaiseChangeEvents                        = False
// CollectionNaming                         = None
// Language                                 = CS
// OutputNamespace                          = LiquidXmlObjects.Schemat
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/KodyUrzedowSkarbowych_v5-0E.xsd
//    http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/KodyKrajow_v5-0E.xsd
//    http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd
//    http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd
//    C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd


namespace LiquidXmlObjects.Schemat
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("19.0.14.11049", "Trial for Non-Commercial Use Expiry [2022-03-05]", "WEELEFYD524QB5L4", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

    #region Global Base Class
    /// <summary>All generated Lx classes derive from this base class.</summary>
    /// <remarks>Notes to implementers. The class is declared partial, so additional members and properties can be added that will be available in all Lx generated classes.</remarks>
    public partial class LxBase
    {
        #region Unprocessed Node Handlers
        /// <summary>Any child elements that do not belong in this element are added to the UnprocessedElements collection.</summary>
        [LxElementUnprocessed()]
        public List<XElement> UnprocessedElements { get; } = new List<XElement>();

        /// <summary>Any attributes that do not belong in this element are added to the UnprocessedAttributes collection.</summary>
        [LxAttributeUnprocessed()]
        public List<XAttribute> UnprocessedAttributes { get; } = new List<XAttribute>();

        #endregion

    }

    #endregion

}

namespace LiquidXmlObjects.Schemat.Etd
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type TCelZlozenia@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Określa, czy to jest złożenie, czy korekta dokumentu</remarks>
    /// <XsdPath>schema:ElementarneTypyDanych_v...xsd/simpleType:TCelZlozenia</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>308:2-324:19</XsdLocation>
    public enum TCelZlozeniaEnum
    {
        /// <summary>Represents the value '1' in the XML</summary>
        [LxEnumValue("1")]
        N1,
        /// <summary>Represents the value '2' in the XML</summary>
        [LxEnumValue("2")]
        N2,
    }
    /// <summary>An enumeration representing XSD simple type TKodKraju@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Słownik kodów krajów</remarks>
    /// <XsdPath>schema:KodyKrajow_v5-0E.xsd/simpleType:TKodKraju</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/KodyKrajow_v5-0E.xsd</XsdFile>
    /// <XsdLocation>6:2-1257:19</XsdLocation>
    public enum TKodKrajuEnum
    {
        /// <summary>Represents the value 'AF' in the XML</summary>
        [LxEnumValue("AF")]
        AF,
        /// <summary>Represents the value 'AX' in the XML</summary>
        [LxEnumValue("AX")]
        AX,
        /// <summary>Represents the value 'AL' in the XML</summary>
        [LxEnumValue("AL")]
        AL,
        /// <summary>Represents the value 'DZ' in the XML</summary>
        [LxEnumValue("DZ")]
        DZ,
        /// <summary>Represents the value 'AD' in the XML</summary>
        [LxEnumValue("AD")]
        AD,
        /// <summary>Represents the value 'AO' in the XML</summary>
        [LxEnumValue("AO")]
        AO,
        /// <summary>Represents the value 'AI' in the XML</summary>
        [LxEnumValue("AI")]
        AI,
        /// <summary>Represents the value 'AQ' in the XML</summary>
        [LxEnumValue("AQ")]
        AQ,
        /// <summary>Represents the value 'AG' in the XML</summary>
        [LxEnumValue("AG")]
        AG,
        /// <summary>Represents the value 'AN' in the XML</summary>
        [LxEnumValue("AN")]
        AN,
        /// <summary>Represents the value 'SA' in the XML</summary>
        [LxEnumValue("SA")]
        SA,
        /// <summary>Represents the value 'AR' in the XML</summary>
        [LxEnumValue("AR")]
        AR,
        /// <summary>Represents the value 'AM' in the XML</summary>
        [LxEnumValue("AM")]
        AM,
        /// <summary>Represents the value 'AW' in the XML</summary>
        [LxEnumValue("AW")]
        AW,
        /// <summary>Represents the value 'AU' in the XML</summary>
        [LxEnumValue("AU")]
        AU,
        /// <summary>Represents the value 'AT' in the XML</summary>
        [LxEnumValue("AT")]
        AT,
        /// <summary>Represents the value 'AZ' in the XML</summary>
        [LxEnumValue("AZ")]
        AZ,
        /// <summary>Represents the value 'BS' in the XML</summary>
        [LxEnumValue("BS")]
        BS,
        /// <summary>Represents the value 'BH' in the XML</summary>
        [LxEnumValue("BH")]
        BH,
        /// <summary>Represents the value 'BD' in the XML</summary>
        [LxEnumValue("BD")]
        BD,
        /// <summary>Represents the value 'BB' in the XML</summary>
        [LxEnumValue("BB")]
        BB,
        /// <summary>Represents the value 'BE' in the XML</summary>
        [LxEnumValue("BE")]
        BE,
        /// <summary>Represents the value 'BZ' in the XML</summary>
        [LxEnumValue("BZ")]
        BZ,
        /// <summary>Represents the value 'BJ' in the XML</summary>
        [LxEnumValue("BJ")]
        BJ,
        /// <summary>Represents the value 'BM' in the XML</summary>
        [LxEnumValue("BM")]
        BM,
        /// <summary>Represents the value 'BT' in the XML</summary>
        [LxEnumValue("BT")]
        BT,
        /// <summary>Represents the value 'BY' in the XML</summary>
        [LxEnumValue("BY")]
        BY,
        /// <summary>Represents the value 'BO' in the XML</summary>
        [LxEnumValue("BO")]
        BO,
        /// <summary>Represents the value 'BA' in the XML</summary>
        [LxEnumValue("BA")]
        BA,
        /// <summary>Represents the value 'BW' in the XML</summary>
        [LxEnumValue("BW")]
        BW,
        /// <summary>Represents the value 'BR' in the XML</summary>
        [LxEnumValue("BR")]
        BR,
        /// <summary>Represents the value 'BN' in the XML</summary>
        [LxEnumValue("BN")]
        BN,
        /// <summary>Represents the value 'IO' in the XML</summary>
        [LxEnumValue("IO")]
        IO,
        /// <summary>Represents the value 'BG' in the XML</summary>
        [LxEnumValue("BG")]
        BG,
        /// <summary>Represents the value 'BF' in the XML</summary>
        [LxEnumValue("BF")]
        BF,
        /// <summary>Represents the value 'BI' in the XML</summary>
        [LxEnumValue("BI")]
        BI,
        /// <summary>Represents the value 'XC' in the XML</summary>
        [LxEnumValue("XC")]
        XC,
        /// <summary>Represents the value 'CL' in the XML</summary>
        [LxEnumValue("CL")]
        CL,
        /// <summary>Represents the value 'CN' in the XML</summary>
        [LxEnumValue("CN")]
        CN,
        /// <summary>Represents the value 'HR' in the XML</summary>
        [LxEnumValue("HR")]
        HR,
        /// <summary>Represents the value 'CY' in the XML</summary>
        [LxEnumValue("CY")]
        CY,
        /// <summary>Represents the value 'TD' in the XML</summary>
        [LxEnumValue("TD")]
        TD,
        /// <summary>Represents the value 'ME' in the XML</summary>
        [LxEnumValue("ME")]
        ME,
        /// <summary>Represents the value 'DK' in the XML</summary>
        [LxEnumValue("DK")]
        DK,
        /// <summary>Represents the value 'DM' in the XML</summary>
        [LxEnumValue("DM")]
        DM,
        /// <summary>Represents the value 'DO' in the XML</summary>
        [LxEnumValue("DO")]
        DO_,
        /// <summary>Represents the value 'DJ' in the XML</summary>
        [LxEnumValue("DJ")]
        DJ,
        /// <summary>Represents the value 'EG' in the XML</summary>
        [LxEnumValue("EG")]
        EG,
        /// <summary>Represents the value 'EC' in the XML</summary>
        [LxEnumValue("EC")]
        EC,
        /// <summary>Represents the value 'ER' in the XML</summary>
        [LxEnumValue("ER")]
        ER,
        /// <summary>Represents the value 'EE' in the XML</summary>
        [LxEnumValue("EE")]
        EE,
        /// <summary>Represents the value 'ET' in the XML</summary>
        [LxEnumValue("ET")]
        ET,
        /// <summary>Represents the value 'FK' in the XML</summary>
        [LxEnumValue("FK")]
        FK,
        /// <summary>Represents the value 'FJ' in the XML</summary>
        [LxEnumValue("FJ")]
        FJ,
        /// <summary>Represents the value 'PH' in the XML</summary>
        [LxEnumValue("PH")]
        PH,
        /// <summary>Represents the value 'FI' in the XML</summary>
        [LxEnumValue("FI")]
        FI,
        /// <summary>Represents the value 'FR' in the XML</summary>
        [LxEnumValue("FR")]
        FR,
        /// <summary>Represents the value 'TF' in the XML</summary>
        [LxEnumValue("TF")]
        TF,
        /// <summary>Represents the value 'GA' in the XML</summary>
        [LxEnumValue("GA")]
        GA,
        /// <summary>Represents the value 'GM' in the XML</summary>
        [LxEnumValue("GM")]
        GM,
        /// <summary>Represents the value 'GH' in the XML</summary>
        [LxEnumValue("GH")]
        GH,
        /// <summary>Represents the value 'GI' in the XML</summary>
        [LxEnumValue("GI")]
        GI,
        /// <summary>Represents the value 'GR' in the XML</summary>
        [LxEnumValue("GR")]
        GR,
        /// <summary>Represents the value 'GD' in the XML</summary>
        [LxEnumValue("GD")]
        GD,
        /// <summary>Represents the value 'GL' in the XML</summary>
        [LxEnumValue("GL")]
        GL,
        /// <summary>Represents the value 'GE' in the XML</summary>
        [LxEnumValue("GE")]
        GE,
        /// <summary>Represents the value 'GU' in the XML</summary>
        [LxEnumValue("GU")]
        GU,
        /// <summary>Represents the value 'GG' in the XML</summary>
        [LxEnumValue("GG")]
        GG,
        /// <summary>Represents the value 'GY' in the XML</summary>
        [LxEnumValue("GY")]
        GY,
        /// <summary>Represents the value 'GF' in the XML</summary>
        [LxEnumValue("GF")]
        GF,
        /// <summary>Represents the value 'GP' in the XML</summary>
        [LxEnumValue("GP")]
        GP,
        /// <summary>Represents the value 'GT' in the XML</summary>
        [LxEnumValue("GT")]
        GT,
        /// <summary>Represents the value 'GN' in the XML</summary>
        [LxEnumValue("GN")]
        GN,
        /// <summary>Represents the value 'GQ' in the XML</summary>
        [LxEnumValue("GQ")]
        GQ,
        /// <summary>Represents the value 'GW' in the XML</summary>
        [LxEnumValue("GW")]
        GW,
        /// <summary>Represents the value 'HT' in the XML</summary>
        [LxEnumValue("HT")]
        HT,
        /// <summary>Represents the value 'ES' in the XML</summary>
        [LxEnumValue("ES")]
        ES,
        /// <summary>Represents the value 'HN' in the XML</summary>
        [LxEnumValue("HN")]
        HN,
        /// <summary>Represents the value 'HK' in the XML</summary>
        [LxEnumValue("HK")]
        HK,
        /// <summary>Represents the value 'IN' in the XML</summary>
        [LxEnumValue("IN")]
        IN_,
        /// <summary>Represents the value 'ID' in the XML</summary>
        [LxEnumValue("ID")]
        ID,
        /// <summary>Represents the value 'IQ' in the XML</summary>
        [LxEnumValue("IQ")]
        IQ,
        /// <summary>Represents the value 'IR' in the XML</summary>
        [LxEnumValue("IR")]
        IR,
        /// <summary>Represents the value 'IE' in the XML</summary>
        [LxEnumValue("IE")]
        IE,
        /// <summary>Represents the value 'IS' in the XML</summary>
        [LxEnumValue("IS")]
        IS_,
        /// <summary>Represents the value 'IL' in the XML</summary>
        [LxEnumValue("IL")]
        IL,
        /// <summary>Represents the value 'JM' in the XML</summary>
        [LxEnumValue("JM")]
        JM,
        /// <summary>Represents the value 'JP' in the XML</summary>
        [LxEnumValue("JP")]
        JP,
        /// <summary>Represents the value 'YE' in the XML</summary>
        [LxEnumValue("YE")]
        YE,
        /// <summary>Represents the value 'JE' in the XML</summary>
        [LxEnumValue("JE")]
        JE,
        /// <summary>Represents the value 'JO' in the XML</summary>
        [LxEnumValue("JO")]
        JO,
        /// <summary>Represents the value 'KY' in the XML</summary>
        [LxEnumValue("KY")]
        KY,
        /// <summary>Represents the value 'KH' in the XML</summary>
        [LxEnumValue("KH")]
        KH,
        /// <summary>Represents the value 'CM' in the XML</summary>
        [LxEnumValue("CM")]
        CM,
        /// <summary>Represents the value 'CA' in the XML</summary>
        [LxEnumValue("CA")]
        CA,
        /// <summary>Represents the value 'QA' in the XML</summary>
        [LxEnumValue("QA")]
        QA,
        /// <summary>Represents the value 'KZ' in the XML</summary>
        [LxEnumValue("KZ")]
        KZ,
        /// <summary>Represents the value 'KE' in the XML</summary>
        [LxEnumValue("KE")]
        KE,
        /// <summary>Represents the value 'KG' in the XML</summary>
        [LxEnumValue("KG")]
        KG,
        /// <summary>Represents the value 'KI' in the XML</summary>
        [LxEnumValue("KI")]
        KI,
        /// <summary>Represents the value 'CO' in the XML</summary>
        [LxEnumValue("CO")]
        CO,
        /// <summary>Represents the value 'KM' in the XML</summary>
        [LxEnumValue("KM")]
        KM,
        /// <summary>Represents the value 'CG' in the XML</summary>
        [LxEnumValue("CG")]
        CG,
        /// <summary>Represents the value 'CD' in the XML</summary>
        [LxEnumValue("CD")]
        CD,
        /// <summary>Represents the value 'KP' in the XML</summary>
        [LxEnumValue("KP")]
        KP,
        /// <summary>Represents the value 'XK' in the XML</summary>
        [LxEnumValue("XK")]
        XK,
        /// <summary>Represents the value 'CR' in the XML</summary>
        [LxEnumValue("CR")]
        CR,
        /// <summary>Represents the value 'CU' in the XML</summary>
        [LxEnumValue("CU")]
        CU,
        /// <summary>Represents the value 'KW' in the XML</summary>
        [LxEnumValue("KW")]
        KW,
        /// <summary>Represents the value 'LA' in the XML</summary>
        [LxEnumValue("LA")]
        LA,
        /// <summary>Represents the value 'LS' in the XML</summary>
        [LxEnumValue("LS")]
        LS,
        /// <summary>Represents the value 'LB' in the XML</summary>
        [LxEnumValue("LB")]
        LB,
        /// <summary>Represents the value 'LR' in the XML</summary>
        [LxEnumValue("LR")]
        LR,
        /// <summary>Represents the value 'LY' in the XML</summary>
        [LxEnumValue("LY")]
        LY,
        /// <summary>Represents the value 'LI' in the XML</summary>
        [LxEnumValue("LI")]
        LI,
        /// <summary>Represents the value 'LT' in the XML</summary>
        [LxEnumValue("LT")]
        LT,
        /// <summary>Represents the value 'LV' in the XML</summary>
        [LxEnumValue("LV")]
        LV,
        /// <summary>Represents the value 'LU' in the XML</summary>
        [LxEnumValue("LU")]
        LU,
        /// <summary>Represents the value 'MK' in the XML</summary>
        [LxEnumValue("MK")]
        MK,
        /// <summary>Represents the value 'MG' in the XML</summary>
        [LxEnumValue("MG")]
        MG,
        /// <summary>Represents the value 'YT' in the XML</summary>
        [LxEnumValue("YT")]
        YT,
        /// <summary>Represents the value 'MO' in the XML</summary>
        [LxEnumValue("MO")]
        MO,
        /// <summary>Represents the value 'MW' in the XML</summary>
        [LxEnumValue("MW")]
        MW,
        /// <summary>Represents the value 'MV' in the XML</summary>
        [LxEnumValue("MV")]
        MV,
        /// <summary>Represents the value 'MY' in the XML</summary>
        [LxEnumValue("MY")]
        MY,
        /// <summary>Represents the value 'ML' in the XML</summary>
        [LxEnumValue("ML")]
        ML,
        /// <summary>Represents the value 'MT' in the XML</summary>
        [LxEnumValue("MT")]
        MT,
        /// <summary>Represents the value 'MP' in the XML</summary>
        [LxEnumValue("MP")]
        MP,
        /// <summary>Represents the value 'MA' in the XML</summary>
        [LxEnumValue("MA")]
        MA,
        /// <summary>Represents the value 'MQ' in the XML</summary>
        [LxEnumValue("MQ")]
        MQ,
        /// <summary>Represents the value 'MR' in the XML</summary>
        [LxEnumValue("MR")]
        MR,
        /// <summary>Represents the value 'MU' in the XML</summary>
        [LxEnumValue("MU")]
        MU,
        /// <summary>Represents the value 'MX' in the XML</summary>
        [LxEnumValue("MX")]
        MX,
        /// <summary>Represents the value 'XL' in the XML</summary>
        [LxEnumValue("XL")]
        XL,
        /// <summary>Represents the value 'FM' in the XML</summary>
        [LxEnumValue("FM")]
        FM,
        /// <summary>Represents the value 'UM' in the XML</summary>
        [LxEnumValue("UM")]
        UM,
        /// <summary>Represents the value 'MD' in the XML</summary>
        [LxEnumValue("MD")]
        MD,
        /// <summary>Represents the value 'MC' in the XML</summary>
        [LxEnumValue("MC")]
        MC,
        /// <summary>Represents the value 'MN' in the XML</summary>
        [LxEnumValue("MN")]
        MN,
        /// <summary>Represents the value 'MS' in the XML</summary>
        [LxEnumValue("MS")]
        MS,
        /// <summary>Represents the value 'MZ' in the XML</summary>
        [LxEnumValue("MZ")]
        MZ,
        /// <summary>Represents the value 'MM' in the XML</summary>
        [LxEnumValue("MM")]
        MM,
        /// <summary>Represents the value 'NA' in the XML</summary>
        [LxEnumValue("NA")]
        NA,
        /// <summary>Represents the value 'NR' in the XML</summary>
        [LxEnumValue("NR")]
        NR,
        /// <summary>Represents the value 'NP' in the XML</summary>
        [LxEnumValue("NP")]
        NP,
        /// <summary>Represents the value 'NL' in the XML</summary>
        [LxEnumValue("NL")]
        NL,
        /// <summary>Represents the value 'DE' in the XML</summary>
        [LxEnumValue("DE")]
        DE,
        /// <summary>Represents the value 'NE' in the XML</summary>
        [LxEnumValue("NE")]
        NE,
        /// <summary>Represents the value 'NG' in the XML</summary>
        [LxEnumValue("NG")]
        NG,
        /// <summary>Represents the value 'NI' in the XML</summary>
        [LxEnumValue("NI")]
        NI,
        /// <summary>Represents the value 'NU' in the XML</summary>
        [LxEnumValue("NU")]
        NU,
        /// <summary>Represents the value 'NF' in the XML</summary>
        [LxEnumValue("NF")]
        NF,
        /// <summary>Represents the value 'NO' in the XML</summary>
        [LxEnumValue("NO")]
        NO,
        /// <summary>Represents the value 'NC' in the XML</summary>
        [LxEnumValue("NC")]
        NC,
        /// <summary>Represents the value 'NZ' in the XML</summary>
        [LxEnumValue("NZ")]
        NZ,
        /// <summary>Represents the value 'PS' in the XML</summary>
        [LxEnumValue("PS")]
        PS,
        /// <summary>Represents the value 'OM' in the XML</summary>
        [LxEnumValue("OM")]
        OM,
        /// <summary>Represents the value 'PK' in the XML</summary>
        [LxEnumValue("PK")]
        PK,
        /// <summary>Represents the value 'PW' in the XML</summary>
        [LxEnumValue("PW")]
        PW,
        /// <summary>Represents the value 'PA' in the XML</summary>
        [LxEnumValue("PA")]
        PA,
        /// <summary>Represents the value 'PG' in the XML</summary>
        [LxEnumValue("PG")]
        PG,
        /// <summary>Represents the value 'PY' in the XML</summary>
        [LxEnumValue("PY")]
        PY,
        /// <summary>Represents the value 'PE' in the XML</summary>
        [LxEnumValue("PE")]
        PE,
        /// <summary>Represents the value 'PN' in the XML</summary>
        [LxEnumValue("PN")]
        PN,
        /// <summary>Represents the value 'PF' in the XML</summary>
        [LxEnumValue("PF")]
        PF,
        /// <summary>Represents the value 'PL' in the XML</summary>
        [LxEnumValue("PL")]
        PL,
        /// <summary>Represents the value 'GS' in the XML</summary>
        [LxEnumValue("GS")]
        GS,
        /// <summary>Represents the value 'PT' in the XML</summary>
        [LxEnumValue("PT")]
        PT,
        /// <summary>Represents the value 'PR' in the XML</summary>
        [LxEnumValue("PR")]
        PR,
        /// <summary>Represents the value 'CF' in the XML</summary>
        [LxEnumValue("CF")]
        CF,
        /// <summary>Represents the value 'CZ' in the XML</summary>
        [LxEnumValue("CZ")]
        CZ,
        /// <summary>Represents the value 'KR' in the XML</summary>
        [LxEnumValue("KR")]
        KR,
        /// <summary>Represents the value 'ZA' in the XML</summary>
        [LxEnumValue("ZA")]
        ZA,
        /// <summary>Represents the value 'RE' in the XML</summary>
        [LxEnumValue("RE")]
        RE,
        /// <summary>Represents the value 'RU' in the XML</summary>
        [LxEnumValue("RU")]
        RU,
        /// <summary>Represents the value 'RO' in the XML</summary>
        [LxEnumValue("RO")]
        RO,
        /// <summary>Represents the value 'RW' in the XML</summary>
        [LxEnumValue("RW")]
        RW,
        /// <summary>Represents the value 'EH' in the XML</summary>
        [LxEnumValue("EH")]
        EH,
        /// <summary>Represents the value 'BL' in the XML</summary>
        [LxEnumValue("BL")]
        BL,
        /// <summary>Represents the value 'KN' in the XML</summary>
        [LxEnumValue("KN")]
        KN,
        /// <summary>Represents the value 'LC' in the XML</summary>
        [LxEnumValue("LC")]
        LC,
        /// <summary>Represents the value 'MF' in the XML</summary>
        [LxEnumValue("MF")]
        MF,
        /// <summary>Represents the value 'VC' in the XML</summary>
        [LxEnumValue("VC")]
        VC,
        /// <summary>Represents the value 'SV' in the XML</summary>
        [LxEnumValue("SV")]
        SV,
        /// <summary>Represents the value 'WS' in the XML</summary>
        [LxEnumValue("WS")]
        WS,
        /// <summary>Represents the value 'AS' in the XML</summary>
        [LxEnumValue("AS")]
        AS_,
        /// <summary>Represents the value 'SM' in the XML</summary>
        [LxEnumValue("SM")]
        SM,
        /// <summary>Represents the value 'SN' in the XML</summary>
        [LxEnumValue("SN")]
        SN,
        /// <summary>Represents the value 'RS' in the XML</summary>
        [LxEnumValue("RS")]
        RS,
        /// <summary>Represents the value 'SC' in the XML</summary>
        [LxEnumValue("SC")]
        SC,
        /// <summary>Represents the value 'SL' in the XML</summary>
        [LxEnumValue("SL")]
        SL,
        /// <summary>Represents the value 'SG' in the XML</summary>
        [LxEnumValue("SG")]
        SG,
        /// <summary>Represents the value 'SK' in the XML</summary>
        [LxEnumValue("SK")]
        SK,
        /// <summary>Represents the value 'SI' in the XML</summary>
        [LxEnumValue("SI")]
        SI,
        /// <summary>Represents the value 'SO' in the XML</summary>
        [LxEnumValue("SO")]
        SO,
        /// <summary>Represents the value 'LK' in the XML</summary>
        [LxEnumValue("LK")]
        LK,
        /// <summary>Represents the value 'PM' in the XML</summary>
        [LxEnumValue("PM")]
        PM,
        /// <summary>Represents the value 'US' in the XML</summary>
        [LxEnumValue("US")]
        US,
        /// <summary>Represents the value 'SZ' in the XML</summary>
        [LxEnumValue("SZ")]
        SZ,
        /// <summary>Represents the value 'SD' in the XML</summary>
        [LxEnumValue("SD")]
        SD,
        /// <summary>Represents the value 'SR' in the XML</summary>
        [LxEnumValue("SR")]
        SR,
        /// <summary>Represents the value 'SJ' in the XML</summary>
        [LxEnumValue("SJ")]
        SJ,
        /// <summary>Represents the value 'SH' in the XML</summary>
        [LxEnumValue("SH")]
        SH,
        /// <summary>Represents the value 'SY' in the XML</summary>
        [LxEnumValue("SY")]
        SY,
        /// <summary>Represents the value 'CH' in the XML</summary>
        [LxEnumValue("CH")]
        CH,
        /// <summary>Represents the value 'SE' in the XML</summary>
        [LxEnumValue("SE")]
        SE,
        /// <summary>Represents the value 'TJ' in the XML</summary>
        [LxEnumValue("TJ")]
        TJ,
        /// <summary>Represents the value 'TH' in the XML</summary>
        [LxEnumValue("TH")]
        TH,
        /// <summary>Represents the value 'TW' in the XML</summary>
        [LxEnumValue("TW")]
        TW,
        /// <summary>Represents the value 'TZ' in the XML</summary>
        [LxEnumValue("TZ")]
        TZ,
        /// <summary>Represents the value 'TG' in the XML</summary>
        [LxEnumValue("TG")]
        TG,
        /// <summary>Represents the value 'TK' in the XML</summary>
        [LxEnumValue("TK")]
        TK,
        /// <summary>Represents the value 'TO' in the XML</summary>
        [LxEnumValue("TO")]
        TO_,
        /// <summary>Represents the value 'TT' in the XML</summary>
        [LxEnumValue("TT")]
        TT,
        /// <summary>Represents the value 'TN' in the XML</summary>
        [LxEnumValue("TN")]
        TN,
        /// <summary>Represents the value 'TR' in the XML</summary>
        [LxEnumValue("TR")]
        TR,
        /// <summary>Represents the value 'TM' in the XML</summary>
        [LxEnumValue("TM")]
        TM,
        /// <summary>Represents the value 'TV' in the XML</summary>
        [LxEnumValue("TV")]
        TV,
        /// <summary>Represents the value 'UG' in the XML</summary>
        [LxEnumValue("UG")]
        UG,
        /// <summary>Represents the value 'UA' in the XML</summary>
        [LxEnumValue("UA")]
        UA,
        /// <summary>Represents the value 'UY' in the XML</summary>
        [LxEnumValue("UY")]
        UY,
        /// <summary>Represents the value 'UZ' in the XML</summary>
        [LxEnumValue("UZ")]
        UZ,
        /// <summary>Represents the value 'VU' in the XML</summary>
        [LxEnumValue("VU")]
        VU,
        /// <summary>Represents the value 'WF' in the XML</summary>
        [LxEnumValue("WF")]
        WF,
        /// <summary>Represents the value 'VA' in the XML</summary>
        [LxEnumValue("VA")]
        VA,
        /// <summary>Represents the value 'HU' in the XML</summary>
        [LxEnumValue("HU")]
        HU,
        /// <summary>Represents the value 'VE' in the XML</summary>
        [LxEnumValue("VE")]
        VE,
        /// <summary>Represents the value 'GB' in the XML</summary>
        [LxEnumValue("GB")]
        GB,
        /// <summary>Represents the value 'VN' in the XML</summary>
        [LxEnumValue("VN")]
        VN,
        /// <summary>Represents the value 'IT' in the XML</summary>
        [LxEnumValue("IT")]
        IT,
        /// <summary>Represents the value 'TL' in the XML</summary>
        [LxEnumValue("TL")]
        TL,
        /// <summary>Represents the value 'CI' in the XML</summary>
        [LxEnumValue("CI")]
        CI,
        /// <summary>Represents the value 'BV' in the XML</summary>
        [LxEnumValue("BV")]
        BV,
        /// <summary>Represents the value 'CX' in the XML</summary>
        [LxEnumValue("CX")]
        CX,
        /// <summary>Represents the value 'IM' in the XML</summary>
        [LxEnumValue("IM")]
        IM,
        /// <summary>Represents the value 'CK' in the XML</summary>
        [LxEnumValue("CK")]
        CK,
        /// <summary>Represents the value 'VI' in the XML</summary>
        [LxEnumValue("VI")]
        VI,
        /// <summary>Represents the value 'VG' in the XML</summary>
        [LxEnumValue("VG")]
        VG,
        /// <summary>Represents the value 'HM' in the XML</summary>
        [LxEnumValue("HM")]
        HM,
        /// <summary>Represents the value 'CC' in the XML</summary>
        [LxEnumValue("CC")]
        CC,
        /// <summary>Represents the value 'MH' in the XML</summary>
        [LxEnumValue("MH")]
        MH,
        /// <summary>Represents the value 'FO' in the XML</summary>
        [LxEnumValue("FO")]
        FO,
        /// <summary>Represents the value 'SB' in the XML</summary>
        [LxEnumValue("SB")]
        SB,
        /// <summary>Represents the value 'ST' in the XML</summary>
        [LxEnumValue("ST")]
        ST,
        /// <summary>Represents the value 'TC' in the XML</summary>
        [LxEnumValue("TC")]
        TC,
        /// <summary>Represents the value 'ZM' in the XML</summary>
        [LxEnumValue("ZM")]
        ZM,
        /// <summary>Represents the value 'CV' in the XML</summary>
        [LxEnumValue("CV")]
        CV,
        /// <summary>Represents the value 'ZW' in the XML</summary>
        [LxEnumValue("ZW")]
        ZW,
        /// <summary>Represents the value 'AE' in the XML</summary>
        [LxEnumValue("AE")]
        AE,
    }
    /// <summary>An enumeration representing XSD simple type TKodUS@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <XsdPath>schema:KodyUrzedowSkarbowych_v...xsd/simpleType:TKodUS</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/KodyUrzedowSkarbowych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>6:2-2009:19</XsdLocation>
    public enum TKodUSEnum
    {
        /// <summary>Represents the value '0202' in the XML</summary>
        [LxEnumValue("0202")]
        N0202,
        /// <summary>Represents the value '0203' in the XML</summary>
        [LxEnumValue("0203")]
        N0203,
        /// <summary>Represents the value '0204' in the XML</summary>
        [LxEnumValue("0204")]
        N0204,
        /// <summary>Represents the value '0205' in the XML</summary>
        [LxEnumValue("0205")]
        N0205,
        /// <summary>Represents the value '0206' in the XML</summary>
        [LxEnumValue("0206")]
        N0206,
        /// <summary>Represents the value '0207' in the XML</summary>
        [LxEnumValue("0207")]
        N0207,
        /// <summary>Represents the value '0208' in the XML</summary>
        [LxEnumValue("0208")]
        N0208,
        /// <summary>Represents the value '0209' in the XML</summary>
        [LxEnumValue("0209")]
        N0209,
        /// <summary>Represents the value '0210' in the XML</summary>
        [LxEnumValue("0210")]
        N0210,
        /// <summary>Represents the value '0211' in the XML</summary>
        [LxEnumValue("0211")]
        N0211,
        /// <summary>Represents the value '0212' in the XML</summary>
        [LxEnumValue("0212")]
        N0212,
        /// <summary>Represents the value '0213' in the XML</summary>
        [LxEnumValue("0213")]
        N0213,
        /// <summary>Represents the value '0214' in the XML</summary>
        [LxEnumValue("0214")]
        N0214,
        /// <summary>Represents the value '0215' in the XML</summary>
        [LxEnumValue("0215")]
        N0215,
        /// <summary>Represents the value '0216' in the XML</summary>
        [LxEnumValue("0216")]
        N0216,
        /// <summary>Represents the value '0217' in the XML</summary>
        [LxEnumValue("0217")]
        N0217,
        /// <summary>Represents the value '0218' in the XML</summary>
        [LxEnumValue("0218")]
        N0218,
        /// <summary>Represents the value '0219' in the XML</summary>
        [LxEnumValue("0219")]
        N0219,
        /// <summary>Represents the value '0220' in the XML</summary>
        [LxEnumValue("0220")]
        N0220,
        /// <summary>Represents the value '0221' in the XML</summary>
        [LxEnumValue("0221")]
        N0221,
        /// <summary>Represents the value '0222' in the XML</summary>
        [LxEnumValue("0222")]
        N0222,
        /// <summary>Represents the value '0223' in the XML</summary>
        [LxEnumValue("0223")]
        N0223,
        /// <summary>Represents the value '0224' in the XML</summary>
        [LxEnumValue("0224")]
        N0224,
        /// <summary>Represents the value '0225' in the XML</summary>
        [LxEnumValue("0225")]
        N0225,
        /// <summary>Represents the value '0226' in the XML</summary>
        [LxEnumValue("0226")]
        N0226,
        /// <summary>Represents the value '0227' in the XML</summary>
        [LxEnumValue("0227")]
        N0227,
        /// <summary>Represents the value '0228' in the XML</summary>
        [LxEnumValue("0228")]
        N0228,
        /// <summary>Represents the value '0229' in the XML</summary>
        [LxEnumValue("0229")]
        N0229,
        /// <summary>Represents the value '0230' in the XML</summary>
        [LxEnumValue("0230")]
        N0230,
        /// <summary>Represents the value '0231' in the XML</summary>
        [LxEnumValue("0231")]
        N0231,
        /// <summary>Represents the value '0232' in the XML</summary>
        [LxEnumValue("0232")]
        N0232,
        /// <summary>Represents the value '0233' in the XML</summary>
        [LxEnumValue("0233")]
        N0233,
        /// <summary>Represents the value '0234' in the XML</summary>
        [LxEnumValue("0234")]
        N0234,
        /// <summary>Represents the value '0271' in the XML</summary>
        [LxEnumValue("0271")]
        N0271,
        /// <summary>Represents the value '0402' in the XML</summary>
        [LxEnumValue("0402")]
        N0402,
        /// <summary>Represents the value '0403' in the XML</summary>
        [LxEnumValue("0403")]
        N0403,
        /// <summary>Represents the value '0404' in the XML</summary>
        [LxEnumValue("0404")]
        N0404,
        /// <summary>Represents the value '0405' in the XML</summary>
        [LxEnumValue("0405")]
        N0405,
        /// <summary>Represents the value '0406' in the XML</summary>
        [LxEnumValue("0406")]
        N0406,
        /// <summary>Represents the value '0407' in the XML</summary>
        [LxEnumValue("0407")]
        N0407,
        /// <summary>Represents the value '0408' in the XML</summary>
        [LxEnumValue("0408")]
        N0408,
        /// <summary>Represents the value '0409' in the XML</summary>
        [LxEnumValue("0409")]
        N0409,
        /// <summary>Represents the value '0410' in the XML</summary>
        [LxEnumValue("0410")]
        N0410,
        /// <summary>Represents the value '0411' in the XML</summary>
        [LxEnumValue("0411")]
        N0411,
        /// <summary>Represents the value '0412' in the XML</summary>
        [LxEnumValue("0412")]
        N0412,
        /// <summary>Represents the value '0413' in the XML</summary>
        [LxEnumValue("0413")]
        N0413,
        /// <summary>Represents the value '0414' in the XML</summary>
        [LxEnumValue("0414")]
        N0414,
        /// <summary>Represents the value '0415' in the XML</summary>
        [LxEnumValue("0415")]
        N0415,
        /// <summary>Represents the value '0416' in the XML</summary>
        [LxEnumValue("0416")]
        N0416,
        /// <summary>Represents the value '0417' in the XML</summary>
        [LxEnumValue("0417")]
        N0417,
        /// <summary>Represents the value '0418' in the XML</summary>
        [LxEnumValue("0418")]
        N0418,
        /// <summary>Represents the value '0419' in the XML</summary>
        [LxEnumValue("0419")]
        N0419,
        /// <summary>Represents the value '0420' in the XML</summary>
        [LxEnumValue("0420")]
        N0420,
        /// <summary>Represents the value '0421' in the XML</summary>
        [LxEnumValue("0421")]
        N0421,
        /// <summary>Represents the value '0422' in the XML</summary>
        [LxEnumValue("0422")]
        N0422,
        /// <summary>Represents the value '0423' in the XML</summary>
        [LxEnumValue("0423")]
        N0423,
        /// <summary>Represents the value '0471' in the XML</summary>
        [LxEnumValue("0471")]
        N0471,
        /// <summary>Represents the value '0602' in the XML</summary>
        [LxEnumValue("0602")]
        N0602,
        /// <summary>Represents the value '0603' in the XML</summary>
        [LxEnumValue("0603")]
        N0603,
        /// <summary>Represents the value '0604' in the XML</summary>
        [LxEnumValue("0604")]
        N0604,
        /// <summary>Represents the value '0605' in the XML</summary>
        [LxEnumValue("0605")]
        N0605,
        /// <summary>Represents the value '0606' in the XML</summary>
        [LxEnumValue("0606")]
        N0606,
        /// <summary>Represents the value '0607' in the XML</summary>
        [LxEnumValue("0607")]
        N0607,
        /// <summary>Represents the value '0608' in the XML</summary>
        [LxEnumValue("0608")]
        N0608,
        /// <summary>Represents the value '0609' in the XML</summary>
        [LxEnumValue("0609")]
        N0609,
        /// <summary>Represents the value '0610' in the XML</summary>
        [LxEnumValue("0610")]
        N0610,
        /// <summary>Represents the value '0611' in the XML</summary>
        [LxEnumValue("0611")]
        N0611,
        /// <summary>Represents the value '0612' in the XML</summary>
        [LxEnumValue("0612")]
        N0612,
        /// <summary>Represents the value '0613' in the XML</summary>
        [LxEnumValue("0613")]
        N0613,
        /// <summary>Represents the value '0614' in the XML</summary>
        [LxEnumValue("0614")]
        N0614,
        /// <summary>Represents the value '0615' in the XML</summary>
        [LxEnumValue("0615")]
        N0615,
        /// <summary>Represents the value '0616' in the XML</summary>
        [LxEnumValue("0616")]
        N0616,
        /// <summary>Represents the value '0617' in the XML</summary>
        [LxEnumValue("0617")]
        N0617,
        /// <summary>Represents the value '0618' in the XML</summary>
        [LxEnumValue("0618")]
        N0618,
        /// <summary>Represents the value '0619' in the XML</summary>
        [LxEnumValue("0619")]
        N0619,
        /// <summary>Represents the value '0620' in the XML</summary>
        [LxEnumValue("0620")]
        N0620,
        /// <summary>Represents the value '0621' in the XML</summary>
        [LxEnumValue("0621")]
        N0621,
        /// <summary>Represents the value '0622' in the XML</summary>
        [LxEnumValue("0622")]
        N0622,
        /// <summary>Represents the value '0671' in the XML</summary>
        [LxEnumValue("0671")]
        N0671,
        /// <summary>Represents the value '0802' in the XML</summary>
        [LxEnumValue("0802")]
        N0802,
        /// <summary>Represents the value '0803' in the XML</summary>
        [LxEnumValue("0803")]
        N0803,
        /// <summary>Represents the value '0804' in the XML</summary>
        [LxEnumValue("0804")]
        N0804,
        /// <summary>Represents the value '0805' in the XML</summary>
        [LxEnumValue("0805")]
        N0805,
        /// <summary>Represents the value '0806' in the XML</summary>
        [LxEnumValue("0806")]
        N0806,
        /// <summary>Represents the value '0807' in the XML</summary>
        [LxEnumValue("0807")]
        N0807,
        /// <summary>Represents the value '0808' in the XML</summary>
        [LxEnumValue("0808")]
        N0808,
        /// <summary>Represents the value '0809' in the XML</summary>
        [LxEnumValue("0809")]
        N0809,
        /// <summary>Represents the value '0810' in the XML</summary>
        [LxEnumValue("0810")]
        N0810,
        /// <summary>Represents the value '0811' in the XML</summary>
        [LxEnumValue("0811")]
        N0811,
        /// <summary>Represents the value '0812' in the XML</summary>
        [LxEnumValue("0812")]
        N0812,
        /// <summary>Represents the value '0813' in the XML</summary>
        [LxEnumValue("0813")]
        N0813,
        /// <summary>Represents the value '0814' in the XML</summary>
        [LxEnumValue("0814")]
        N0814,
        /// <summary>Represents the value '0871' in the XML</summary>
        [LxEnumValue("0871")]
        N0871,
        /// <summary>Represents the value '1002' in the XML</summary>
        [LxEnumValue("1002")]
        N1002,
        /// <summary>Represents the value '1003' in the XML</summary>
        [LxEnumValue("1003")]
        N1003,
        /// <summary>Represents the value '1004' in the XML</summary>
        [LxEnumValue("1004")]
        N1004,
        /// <summary>Represents the value '1005' in the XML</summary>
        [LxEnumValue("1005")]
        N1005,
        /// <summary>Represents the value '1006' in the XML</summary>
        [LxEnumValue("1006")]
        N1006,
        /// <summary>Represents the value '1007' in the XML</summary>
        [LxEnumValue("1007")]
        N1007,
        /// <summary>Represents the value '1008' in the XML</summary>
        [LxEnumValue("1008")]
        N1008,
        /// <summary>Represents the value '1009' in the XML</summary>
        [LxEnumValue("1009")]
        N1009,
        /// <summary>Represents the value '1010' in the XML</summary>
        [LxEnumValue("1010")]
        N1010,
        /// <summary>Represents the value '1011' in the XML</summary>
        [LxEnumValue("1011")]
        N1011,
        /// <summary>Represents the value '1012' in the XML</summary>
        [LxEnumValue("1012")]
        N1012,
        /// <summary>Represents the value '1013' in the XML</summary>
        [LxEnumValue("1013")]
        N1013,
        /// <summary>Represents the value '1014' in the XML</summary>
        [LxEnumValue("1014")]
        N1014,
        /// <summary>Represents the value '1015' in the XML</summary>
        [LxEnumValue("1015")]
        N1015,
        /// <summary>Represents the value '1016' in the XML</summary>
        [LxEnumValue("1016")]
        N1016,
        /// <summary>Represents the value '1017' in the XML</summary>
        [LxEnumValue("1017")]
        N1017,
        /// <summary>Represents the value '1018' in the XML</summary>
        [LxEnumValue("1018")]
        N1018,
        /// <summary>Represents the value '1019' in the XML</summary>
        [LxEnumValue("1019")]
        N1019,
        /// <summary>Represents the value '1020' in the XML</summary>
        [LxEnumValue("1020")]
        N1020,
        /// <summary>Represents the value '1021' in the XML</summary>
        [LxEnumValue("1021")]
        N1021,
        /// <summary>Represents the value '1022' in the XML</summary>
        [LxEnumValue("1022")]
        N1022,
        /// <summary>Represents the value '1023' in the XML</summary>
        [LxEnumValue("1023")]
        N1023,
        /// <summary>Represents the value '1024' in the XML</summary>
        [LxEnumValue("1024")]
        N1024,
        /// <summary>Represents the value '1025' in the XML</summary>
        [LxEnumValue("1025")]
        N1025,
        /// <summary>Represents the value '1026' in the XML</summary>
        [LxEnumValue("1026")]
        N1026,
        /// <summary>Represents the value '1027' in the XML</summary>
        [LxEnumValue("1027")]
        N1027,
        /// <summary>Represents the value '1028' in the XML</summary>
        [LxEnumValue("1028")]
        N1028,
        /// <summary>Represents the value '1029' in the XML</summary>
        [LxEnumValue("1029")]
        N1029,
        /// <summary>Represents the value '1071' in the XML</summary>
        [LxEnumValue("1071")]
        N1071,
        /// <summary>Represents the value '1202' in the XML</summary>
        [LxEnumValue("1202")]
        N1202,
        /// <summary>Represents the value '1203' in the XML</summary>
        [LxEnumValue("1203")]
        N1203,
        /// <summary>Represents the value '1204' in the XML</summary>
        [LxEnumValue("1204")]
        N1204,
        /// <summary>Represents the value '1205' in the XML</summary>
        [LxEnumValue("1205")]
        N1205,
        /// <summary>Represents the value '1206' in the XML</summary>
        [LxEnumValue("1206")]
        N1206,
        /// <summary>Represents the value '1207' in the XML</summary>
        [LxEnumValue("1207")]
        N1207,
        /// <summary>Represents the value '1208' in the XML</summary>
        [LxEnumValue("1208")]
        N1208,
        /// <summary>Represents the value '1209' in the XML</summary>
        [LxEnumValue("1209")]
        N1209,
        /// <summary>Represents the value '1210' in the XML</summary>
        [LxEnumValue("1210")]
        N1210,
        /// <summary>Represents the value '1211' in the XML</summary>
        [LxEnumValue("1211")]
        N1211,
        /// <summary>Represents the value '1212' in the XML</summary>
        [LxEnumValue("1212")]
        N1212,
        /// <summary>Represents the value '1213' in the XML</summary>
        [LxEnumValue("1213")]
        N1213,
        /// <summary>Represents the value '1214' in the XML</summary>
        [LxEnumValue("1214")]
        N1214,
        /// <summary>Represents the value '1215' in the XML</summary>
        [LxEnumValue("1215")]
        N1215,
        /// <summary>Represents the value '1216' in the XML</summary>
        [LxEnumValue("1216")]
        N1216,
        /// <summary>Represents the value '1217' in the XML</summary>
        [LxEnumValue("1217")]
        N1217,
        /// <summary>Represents the value '1218' in the XML</summary>
        [LxEnumValue("1218")]
        N1218,
        /// <summary>Represents the value '1219' in the XML</summary>
        [LxEnumValue("1219")]
        N1219,
        /// <summary>Represents the value '1220' in the XML</summary>
        [LxEnumValue("1220")]
        N1220,
        /// <summary>Represents the value '1221' in the XML</summary>
        [LxEnumValue("1221")]
        N1221,
        /// <summary>Represents the value '1222' in the XML</summary>
        [LxEnumValue("1222")]
        N1222,
        /// <summary>Represents the value '1223' in the XML</summary>
        [LxEnumValue("1223")]
        N1223,
        /// <summary>Represents the value '1224' in the XML</summary>
        [LxEnumValue("1224")]
        N1224,
        /// <summary>Represents the value '1225' in the XML</summary>
        [LxEnumValue("1225")]
        N1225,
        /// <summary>Represents the value '1226' in the XML</summary>
        [LxEnumValue("1226")]
        N1226,
        /// <summary>Represents the value '1227' in the XML</summary>
        [LxEnumValue("1227")]
        N1227,
        /// <summary>Represents the value '1228' in the XML</summary>
        [LxEnumValue("1228")]
        N1228,
        /// <summary>Represents the value '1271' in the XML</summary>
        [LxEnumValue("1271")]
        N1271,
        /// <summary>Represents the value '1402' in the XML</summary>
        [LxEnumValue("1402")]
        N1402,
        /// <summary>Represents the value '1403' in the XML</summary>
        [LxEnumValue("1403")]
        N1403,
        /// <summary>Represents the value '1404' in the XML</summary>
        [LxEnumValue("1404")]
        N1404,
        /// <summary>Represents the value '1405' in the XML</summary>
        [LxEnumValue("1405")]
        N1405,
        /// <summary>Represents the value '1406' in the XML</summary>
        [LxEnumValue("1406")]
        N1406,
        /// <summary>Represents the value '1407' in the XML</summary>
        [LxEnumValue("1407")]
        N1407,
        /// <summary>Represents the value '1408' in the XML</summary>
        [LxEnumValue("1408")]
        N1408,
        /// <summary>Represents the value '1409' in the XML</summary>
        [LxEnumValue("1409")]
        N1409,
        /// <summary>Represents the value '1410' in the XML</summary>
        [LxEnumValue("1410")]
        N1410,
        /// <summary>Represents the value '1411' in the XML</summary>
        [LxEnumValue("1411")]
        N1411,
        /// <summary>Represents the value '1412' in the XML</summary>
        [LxEnumValue("1412")]
        N1412,
        /// <summary>Represents the value '1413' in the XML</summary>
        [LxEnumValue("1413")]
        N1413,
        /// <summary>Represents the value '1414' in the XML</summary>
        [LxEnumValue("1414")]
        N1414,
        /// <summary>Represents the value '1415' in the XML</summary>
        [LxEnumValue("1415")]
        N1415,
        /// <summary>Represents the value '1416' in the XML</summary>
        [LxEnumValue("1416")]
        N1416,
        /// <summary>Represents the value '1417' in the XML</summary>
        [LxEnumValue("1417")]
        N1417,
        /// <summary>Represents the value '1418' in the XML</summary>
        [LxEnumValue("1418")]
        N1418,
        /// <summary>Represents the value '1419' in the XML</summary>
        [LxEnumValue("1419")]
        N1419,
        /// <summary>Represents the value '1420' in the XML</summary>
        [LxEnumValue("1420")]
        N1420,
        /// <summary>Represents the value '1421' in the XML</summary>
        [LxEnumValue("1421")]
        N1421,
        /// <summary>Represents the value '1422' in the XML</summary>
        [LxEnumValue("1422")]
        N1422,
        /// <summary>Represents the value '1423' in the XML</summary>
        [LxEnumValue("1423")]
        N1423,
        /// <summary>Represents the value '1424' in the XML</summary>
        [LxEnumValue("1424")]
        N1424,
        /// <summary>Represents the value '1425' in the XML</summary>
        [LxEnumValue("1425")]
        N1425,
        /// <summary>Represents the value '1426' in the XML</summary>
        [LxEnumValue("1426")]
        N1426,
        /// <summary>Represents the value '1427' in the XML</summary>
        [LxEnumValue("1427")]
        N1427,
        /// <summary>Represents the value '1428' in the XML</summary>
        [LxEnumValue("1428")]
        N1428,
        /// <summary>Represents the value '1429' in the XML</summary>
        [LxEnumValue("1429")]
        N1429,
        /// <summary>Represents the value '1430' in the XML</summary>
        [LxEnumValue("1430")]
        N1430,
        /// <summary>Represents the value '1431' in the XML</summary>
        [LxEnumValue("1431")]
        N1431,
        /// <summary>Represents the value '1432' in the XML</summary>
        [LxEnumValue("1432")]
        N1432,
        /// <summary>Represents the value '1433' in the XML</summary>
        [LxEnumValue("1433")]
        N1433,
        /// <summary>Represents the value '1434' in the XML</summary>
        [LxEnumValue("1434")]
        N1434,
        /// <summary>Represents the value '1435' in the XML</summary>
        [LxEnumValue("1435")]
        N1435,
        /// <summary>Represents the value '1436' in the XML</summary>
        [LxEnumValue("1436")]
        N1436,
        /// <summary>Represents the value '1437' in the XML</summary>
        [LxEnumValue("1437")]
        N1437,
        /// <summary>Represents the value '1438' in the XML</summary>
        [LxEnumValue("1438")]
        N1438,
        /// <summary>Represents the value '1439' in the XML</summary>
        [LxEnumValue("1439")]
        N1439,
        /// <summary>Represents the value '1440' in the XML</summary>
        [LxEnumValue("1440")]
        N1440,
        /// <summary>Represents the value '1441' in the XML</summary>
        [LxEnumValue("1441")]
        N1441,
        /// <summary>Represents the value '1442' in the XML</summary>
        [LxEnumValue("1442")]
        N1442,
        /// <summary>Represents the value '1443' in the XML</summary>
        [LxEnumValue("1443")]
        N1443,
        /// <summary>Represents the value '1444' in the XML</summary>
        [LxEnumValue("1444")]
        N1444,
        /// <summary>Represents the value '1445' in the XML</summary>
        [LxEnumValue("1445")]
        N1445,
        /// <summary>Represents the value '1446' in the XML</summary>
        [LxEnumValue("1446")]
        N1446,
        /// <summary>Represents the value '1447' in the XML</summary>
        [LxEnumValue("1447")]
        N1447,
        /// <summary>Represents the value '1448' in the XML</summary>
        [LxEnumValue("1448")]
        N1448,
        /// <summary>Represents the value '1449' in the XML</summary>
        [LxEnumValue("1449")]
        N1449,
        /// <summary>Represents the value '1471' in the XML</summary>
        [LxEnumValue("1471")]
        N1471,
        /// <summary>Represents the value '1472' in the XML</summary>
        [LxEnumValue("1472")]
        N1472,
        /// <summary>Represents the value '1473' in the XML</summary>
        [LxEnumValue("1473")]
        N1473,
        /// <summary>Represents the value '1602' in the XML</summary>
        [LxEnumValue("1602")]
        N1602,
        /// <summary>Represents the value '1603' in the XML</summary>
        [LxEnumValue("1603")]
        N1603,
        /// <summary>Represents the value '1604' in the XML</summary>
        [LxEnumValue("1604")]
        N1604,
        /// <summary>Represents the value '1605' in the XML</summary>
        [LxEnumValue("1605")]
        N1605,
        /// <summary>Represents the value '1606' in the XML</summary>
        [LxEnumValue("1606")]
        N1606,
        /// <summary>Represents the value '1607' in the XML</summary>
        [LxEnumValue("1607")]
        N1607,
        /// <summary>Represents the value '1608' in the XML</summary>
        [LxEnumValue("1608")]
        N1608,
        /// <summary>Represents the value '1609' in the XML</summary>
        [LxEnumValue("1609")]
        N1609,
        /// <summary>Represents the value '1610' in the XML</summary>
        [LxEnumValue("1610")]
        N1610,
        /// <summary>Represents the value '1611' in the XML</summary>
        [LxEnumValue("1611")]
        N1611,
        /// <summary>Represents the value '1612' in the XML</summary>
        [LxEnumValue("1612")]
        N1612,
        /// <summary>Represents the value '1613' in the XML</summary>
        [LxEnumValue("1613")]
        N1613,
        /// <summary>Represents the value '1671' in the XML</summary>
        [LxEnumValue("1671")]
        N1671,
        /// <summary>Represents the value '1802' in the XML</summary>
        [LxEnumValue("1802")]
        N1802,
        /// <summary>Represents the value '1803' in the XML</summary>
        [LxEnumValue("1803")]
        N1803,
        /// <summary>Represents the value '1804' in the XML</summary>
        [LxEnumValue("1804")]
        N1804,
        /// <summary>Represents the value '1805' in the XML</summary>
        [LxEnumValue("1805")]
        N1805,
        /// <summary>Represents the value '1806' in the XML</summary>
        [LxEnumValue("1806")]
        N1806,
        /// <summary>Represents the value '1807' in the XML</summary>
        [LxEnumValue("1807")]
        N1807,
        /// <summary>Represents the value '1808' in the XML</summary>
        [LxEnumValue("1808")]
        N1808,
        /// <summary>Represents the value '1809' in the XML</summary>
        [LxEnumValue("1809")]
        N1809,
        /// <summary>Represents the value '1810' in the XML</summary>
        [LxEnumValue("1810")]
        N1810,
        /// <summary>Represents the value '1811' in the XML</summary>
        [LxEnumValue("1811")]
        N1811,
        /// <summary>Represents the value '1812' in the XML</summary>
        [LxEnumValue("1812")]
        N1812,
        /// <summary>Represents the value '1813' in the XML</summary>
        [LxEnumValue("1813")]
        N1813,
        /// <summary>Represents the value '1814' in the XML</summary>
        [LxEnumValue("1814")]
        N1814,
        /// <summary>Represents the value '1815' in the XML</summary>
        [LxEnumValue("1815")]
        N1815,
        /// <summary>Represents the value '1816' in the XML</summary>
        [LxEnumValue("1816")]
        N1816,
        /// <summary>Represents the value '1817' in the XML</summary>
        [LxEnumValue("1817")]
        N1817,
        /// <summary>Represents the value '1818' in the XML</summary>
        [LxEnumValue("1818")]
        N1818,
        /// <summary>Represents the value '1819' in the XML</summary>
        [LxEnumValue("1819")]
        N1819,
        /// <summary>Represents the value '1820' in the XML</summary>
        [LxEnumValue("1820")]
        N1820,
        /// <summary>Represents the value '1821' in the XML</summary>
        [LxEnumValue("1821")]
        N1821,
        /// <summary>Represents the value '1822' in the XML</summary>
        [LxEnumValue("1822")]
        N1822,
        /// <summary>Represents the value '1823' in the XML</summary>
        [LxEnumValue("1823")]
        N1823,
        /// <summary>Represents the value '1871' in the XML</summary>
        [LxEnumValue("1871")]
        N1871,
        /// <summary>Represents the value '2002' in the XML</summary>
        [LxEnumValue("2002")]
        N2002,
        /// <summary>Represents the value '2003' in the XML</summary>
        [LxEnumValue("2003")]
        N2003,
        /// <summary>Represents the value '2004' in the XML</summary>
        [LxEnumValue("2004")]
        N2004,
        /// <summary>Represents the value '2005' in the XML</summary>
        [LxEnumValue("2005")]
        N2005,
        /// <summary>Represents the value '2006' in the XML</summary>
        [LxEnumValue("2006")]
        N2006,
        /// <summary>Represents the value '2007' in the XML</summary>
        [LxEnumValue("2007")]
        N2007,
        /// <summary>Represents the value '2008' in the XML</summary>
        [LxEnumValue("2008")]
        N2008,
        /// <summary>Represents the value '2009' in the XML</summary>
        [LxEnumValue("2009")]
        N2009,
        /// <summary>Represents the value '2010' in the XML</summary>
        [LxEnumValue("2010")]
        N2010,
        /// <summary>Represents the value '2011' in the XML</summary>
        [LxEnumValue("2011")]
        N2011,
        /// <summary>Represents the value '2012' in the XML</summary>
        [LxEnumValue("2012")]
        N2012,
        /// <summary>Represents the value '2013' in the XML</summary>
        [LxEnumValue("2013")]
        N2013,
        /// <summary>Represents the value '2014' in the XML</summary>
        [LxEnumValue("2014")]
        N2014,
        /// <summary>Represents the value '2015' in the XML</summary>
        [LxEnumValue("2015")]
        N2015,
        /// <summary>Represents the value '2071' in the XML</summary>
        [LxEnumValue("2071")]
        N2071,
        /// <summary>Represents the value '2202' in the XML</summary>
        [LxEnumValue("2202")]
        N2202,
        /// <summary>Represents the value '2203' in the XML</summary>
        [LxEnumValue("2203")]
        N2203,
        /// <summary>Represents the value '2204' in the XML</summary>
        [LxEnumValue("2204")]
        N2204,
        /// <summary>Represents the value '2205' in the XML</summary>
        [LxEnumValue("2205")]
        N2205,
        /// <summary>Represents the value '2206' in the XML</summary>
        [LxEnumValue("2206")]
        N2206,
        /// <summary>Represents the value '2207' in the XML</summary>
        [LxEnumValue("2207")]
        N2207,
        /// <summary>Represents the value '2208' in the XML</summary>
        [LxEnumValue("2208")]
        N2208,
        /// <summary>Represents the value '2209' in the XML</summary>
        [LxEnumValue("2209")]
        N2209,
        /// <summary>Represents the value '2210' in the XML</summary>
        [LxEnumValue("2210")]
        N2210,
        /// <summary>Represents the value '2211' in the XML</summary>
        [LxEnumValue("2211")]
        N2211,
        /// <summary>Represents the value '2212' in the XML</summary>
        [LxEnumValue("2212")]
        N2212,
        /// <summary>Represents the value '2213' in the XML</summary>
        [LxEnumValue("2213")]
        N2213,
        /// <summary>Represents the value '2214' in the XML</summary>
        [LxEnumValue("2214")]
        N2214,
        /// <summary>Represents the value '2215' in the XML</summary>
        [LxEnumValue("2215")]
        N2215,
        /// <summary>Represents the value '2216' in the XML</summary>
        [LxEnumValue("2216")]
        N2216,
        /// <summary>Represents the value '2217' in the XML</summary>
        [LxEnumValue("2217")]
        N2217,
        /// <summary>Represents the value '2218' in the XML</summary>
        [LxEnumValue("2218")]
        N2218,
        /// <summary>Represents the value '2219' in the XML</summary>
        [LxEnumValue("2219")]
        N2219,
        /// <summary>Represents the value '2220' in the XML</summary>
        [LxEnumValue("2220")]
        N2220,
        /// <summary>Represents the value '2221' in the XML</summary>
        [LxEnumValue("2221")]
        N2221,
        /// <summary>Represents the value '2271' in the XML</summary>
        [LxEnumValue("2271")]
        N2271,
        /// <summary>Represents the value '2402' in the XML</summary>
        [LxEnumValue("2402")]
        N2402,
        /// <summary>Represents the value '2403' in the XML</summary>
        [LxEnumValue("2403")]
        N2403,
        /// <summary>Represents the value '2404' in the XML</summary>
        [LxEnumValue("2404")]
        N2404,
        /// <summary>Represents the value '2405' in the XML</summary>
        [LxEnumValue("2405")]
        N2405,
        /// <summary>Represents the value '2406' in the XML</summary>
        [LxEnumValue("2406")]
        N2406,
        /// <summary>Represents the value '2407' in the XML</summary>
        [LxEnumValue("2407")]
        N2407,
        /// <summary>Represents the value '2408' in the XML</summary>
        [LxEnumValue("2408")]
        N2408,
        /// <summary>Represents the value '2409' in the XML</summary>
        [LxEnumValue("2409")]
        N2409,
        /// <summary>Represents the value '2410' in the XML</summary>
        [LxEnumValue("2410")]
        N2410,
        /// <summary>Represents the value '2411' in the XML</summary>
        [LxEnumValue("2411")]
        N2411,
        /// <summary>Represents the value '2412' in the XML</summary>
        [LxEnumValue("2412")]
        N2412,
        /// <summary>Represents the value '2413' in the XML</summary>
        [LxEnumValue("2413")]
        N2413,
        /// <summary>Represents the value '2414' in the XML</summary>
        [LxEnumValue("2414")]
        N2414,
        /// <summary>Represents the value '2415' in the XML</summary>
        [LxEnumValue("2415")]
        N2415,
        /// <summary>Represents the value '2416' in the XML</summary>
        [LxEnumValue("2416")]
        N2416,
        /// <summary>Represents the value '2417' in the XML</summary>
        [LxEnumValue("2417")]
        N2417,
        /// <summary>Represents the value '2418' in the XML</summary>
        [LxEnumValue("2418")]
        N2418,
        /// <summary>Represents the value '2419' in the XML</summary>
        [LxEnumValue("2419")]
        N2419,
        /// <summary>Represents the value '2420' in the XML</summary>
        [LxEnumValue("2420")]
        N2420,
        /// <summary>Represents the value '2421' in the XML</summary>
        [LxEnumValue("2421")]
        N2421,
        /// <summary>Represents the value '2422' in the XML</summary>
        [LxEnumValue("2422")]
        N2422,
        /// <summary>Represents the value '2423' in the XML</summary>
        [LxEnumValue("2423")]
        N2423,
        /// <summary>Represents the value '2424' in the XML</summary>
        [LxEnumValue("2424")]
        N2424,
        /// <summary>Represents the value '2425' in the XML</summary>
        [LxEnumValue("2425")]
        N2425,
        /// <summary>Represents the value '2426' in the XML</summary>
        [LxEnumValue("2426")]
        N2426,
        /// <summary>Represents the value '2427' in the XML</summary>
        [LxEnumValue("2427")]
        N2427,
        /// <summary>Represents the value '2428' in the XML</summary>
        [LxEnumValue("2428")]
        N2428,
        /// <summary>Represents the value '2429' in the XML</summary>
        [LxEnumValue("2429")]
        N2429,
        /// <summary>Represents the value '2430' in the XML</summary>
        [LxEnumValue("2430")]
        N2430,
        /// <summary>Represents the value '2431' in the XML</summary>
        [LxEnumValue("2431")]
        N2431,
        /// <summary>Represents the value '2432' in the XML</summary>
        [LxEnumValue("2432")]
        N2432,
        /// <summary>Represents the value '2433' in the XML</summary>
        [LxEnumValue("2433")]
        N2433,
        /// <summary>Represents the value '2434' in the XML</summary>
        [LxEnumValue("2434")]
        N2434,
        /// <summary>Represents the value '2435' in the XML</summary>
        [LxEnumValue("2435")]
        N2435,
        /// <summary>Represents the value '2436' in the XML</summary>
        [LxEnumValue("2436")]
        N2436,
        /// <summary>Represents the value '2471' in the XML</summary>
        [LxEnumValue("2471")]
        N2471,
        /// <summary>Represents the value '2472' in the XML</summary>
        [LxEnumValue("2472")]
        N2472,
        /// <summary>Represents the value '2602' in the XML</summary>
        [LxEnumValue("2602")]
        N2602,
        /// <summary>Represents the value '2603' in the XML</summary>
        [LxEnumValue("2603")]
        N2603,
        /// <summary>Represents the value '2604' in the XML</summary>
        [LxEnumValue("2604")]
        N2604,
        /// <summary>Represents the value '2605' in the XML</summary>
        [LxEnumValue("2605")]
        N2605,
        /// <summary>Represents the value '2606' in the XML</summary>
        [LxEnumValue("2606")]
        N2606,
        /// <summary>Represents the value '2607' in the XML</summary>
        [LxEnumValue("2607")]
        N2607,
        /// <summary>Represents the value '2608' in the XML</summary>
        [LxEnumValue("2608")]
        N2608,
        /// <summary>Represents the value '2609' in the XML</summary>
        [LxEnumValue("2609")]
        N2609,
        /// <summary>Represents the value '2610' in the XML</summary>
        [LxEnumValue("2610")]
        N2610,
        /// <summary>Represents the value '2611' in the XML</summary>
        [LxEnumValue("2611")]
        N2611,
        /// <summary>Represents the value '2612' in the XML</summary>
        [LxEnumValue("2612")]
        N2612,
        /// <summary>Represents the value '2613' in the XML</summary>
        [LxEnumValue("2613")]
        N2613,
        /// <summary>Represents the value '2614' in the XML</summary>
        [LxEnumValue("2614")]
        N2614,
        /// <summary>Represents the value '2615' in the XML</summary>
        [LxEnumValue("2615")]
        N2615,
        /// <summary>Represents the value '2671' in the XML</summary>
        [LxEnumValue("2671")]
        N2671,
        /// <summary>Represents the value '2802' in the XML</summary>
        [LxEnumValue("2802")]
        N2802,
        /// <summary>Represents the value '2803' in the XML</summary>
        [LxEnumValue("2803")]
        N2803,
        /// <summary>Represents the value '2804' in the XML</summary>
        [LxEnumValue("2804")]
        N2804,
        /// <summary>Represents the value '2805' in the XML</summary>
        [LxEnumValue("2805")]
        N2805,
        /// <summary>Represents the value '2806' in the XML</summary>
        [LxEnumValue("2806")]
        N2806,
        /// <summary>Represents the value '2807' in the XML</summary>
        [LxEnumValue("2807")]
        N2807,
        /// <summary>Represents the value '2808' in the XML</summary>
        [LxEnumValue("2808")]
        N2808,
        /// <summary>Represents the value '2809' in the XML</summary>
        [LxEnumValue("2809")]
        N2809,
        /// <summary>Represents the value '2810' in the XML</summary>
        [LxEnumValue("2810")]
        N2810,
        /// <summary>Represents the value '2811' in the XML</summary>
        [LxEnumValue("2811")]
        N2811,
        /// <summary>Represents the value '2812' in the XML</summary>
        [LxEnumValue("2812")]
        N2812,
        /// <summary>Represents the value '2813' in the XML</summary>
        [LxEnumValue("2813")]
        N2813,
        /// <summary>Represents the value '2814' in the XML</summary>
        [LxEnumValue("2814")]
        N2814,
        /// <summary>Represents the value '2815' in the XML</summary>
        [LxEnumValue("2815")]
        N2815,
        /// <summary>Represents the value '2816' in the XML</summary>
        [LxEnumValue("2816")]
        N2816,
        /// <summary>Represents the value '2871' in the XML</summary>
        [LxEnumValue("2871")]
        N2871,
        /// <summary>Represents the value '3002' in the XML</summary>
        [LxEnumValue("3002")]
        N3002,
        /// <summary>Represents the value '3003' in the XML</summary>
        [LxEnumValue("3003")]
        N3003,
        /// <summary>Represents the value '3004' in the XML</summary>
        [LxEnumValue("3004")]
        N3004,
        /// <summary>Represents the value '3005' in the XML</summary>
        [LxEnumValue("3005")]
        N3005,
        /// <summary>Represents the value '3006' in the XML</summary>
        [LxEnumValue("3006")]
        N3006,
        /// <summary>Represents the value '3007' in the XML</summary>
        [LxEnumValue("3007")]
        N3007,
        /// <summary>Represents the value '3008' in the XML</summary>
        [LxEnumValue("3008")]
        N3008,
        /// <summary>Represents the value '3009' in the XML</summary>
        [LxEnumValue("3009")]
        N3009,
        /// <summary>Represents the value '3010' in the XML</summary>
        [LxEnumValue("3010")]
        N3010,
        /// <summary>Represents the value '3011' in the XML</summary>
        [LxEnumValue("3011")]
        N3011,
        /// <summary>Represents the value '3012' in the XML</summary>
        [LxEnumValue("3012")]
        N3012,
        /// <summary>Represents the value '3013' in the XML</summary>
        [LxEnumValue("3013")]
        N3013,
        /// <summary>Represents the value '3014' in the XML</summary>
        [LxEnumValue("3014")]
        N3014,
        /// <summary>Represents the value '3015' in the XML</summary>
        [LxEnumValue("3015")]
        N3015,
        /// <summary>Represents the value '3016' in the XML</summary>
        [LxEnumValue("3016")]
        N3016,
        /// <summary>Represents the value '3017' in the XML</summary>
        [LxEnumValue("3017")]
        N3017,
        /// <summary>Represents the value '3018' in the XML</summary>
        [LxEnumValue("3018")]
        N3018,
        /// <summary>Represents the value '3019' in the XML</summary>
        [LxEnumValue("3019")]
        N3019,
        /// <summary>Represents the value '3020' in the XML</summary>
        [LxEnumValue("3020")]
        N3020,
        /// <summary>Represents the value '3021' in the XML</summary>
        [LxEnumValue("3021")]
        N3021,
        /// <summary>Represents the value '3022' in the XML</summary>
        [LxEnumValue("3022")]
        N3022,
        /// <summary>Represents the value '3023' in the XML</summary>
        [LxEnumValue("3023")]
        N3023,
        /// <summary>Represents the value '3025' in the XML</summary>
        [LxEnumValue("3025")]
        N3025,
        /// <summary>Represents the value '3026' in the XML</summary>
        [LxEnumValue("3026")]
        N3026,
        /// <summary>Represents the value '3027' in the XML</summary>
        [LxEnumValue("3027")]
        N3027,
        /// <summary>Represents the value '3028' in the XML</summary>
        [LxEnumValue("3028")]
        N3028,
        /// <summary>Represents the value '3029' in the XML</summary>
        [LxEnumValue("3029")]
        N3029,
        /// <summary>Represents the value '3030' in the XML</summary>
        [LxEnumValue("3030")]
        N3030,
        /// <summary>Represents the value '3031' in the XML</summary>
        [LxEnumValue("3031")]
        N3031,
        /// <summary>Represents the value '3032' in the XML</summary>
        [LxEnumValue("3032")]
        N3032,
        /// <summary>Represents the value '3033' in the XML</summary>
        [LxEnumValue("3033")]
        N3033,
        /// <summary>Represents the value '3034' in the XML</summary>
        [LxEnumValue("3034")]
        N3034,
        /// <summary>Represents the value '3035' in the XML</summary>
        [LxEnumValue("3035")]
        N3035,
        /// <summary>Represents the value '3036' in the XML</summary>
        [LxEnumValue("3036")]
        N3036,
        /// <summary>Represents the value '3037' in the XML</summary>
        [LxEnumValue("3037")]
        N3037,
        /// <summary>Represents the value '3038' in the XML</summary>
        [LxEnumValue("3038")]
        N3038,
        /// <summary>Represents the value '3039' in the XML</summary>
        [LxEnumValue("3039")]
        N3039,
        /// <summary>Represents the value '3071' in the XML</summary>
        [LxEnumValue("3071")]
        N3071,
        /// <summary>Represents the value '3072' in the XML</summary>
        [LxEnumValue("3072")]
        N3072,
        /// <summary>Represents the value '3202' in the XML</summary>
        [LxEnumValue("3202")]
        N3202,
        /// <summary>Represents the value '3203' in the XML</summary>
        [LxEnumValue("3203")]
        N3203,
        /// <summary>Represents the value '3204' in the XML</summary>
        [LxEnumValue("3204")]
        N3204,
        /// <summary>Represents the value '3205' in the XML</summary>
        [LxEnumValue("3205")]
        N3205,
        /// <summary>Represents the value '3206' in the XML</summary>
        [LxEnumValue("3206")]
        N3206,
        /// <summary>Represents the value '3207' in the XML</summary>
        [LxEnumValue("3207")]
        N3207,
        /// <summary>Represents the value '3208' in the XML</summary>
        [LxEnumValue("3208")]
        N3208,
        /// <summary>Represents the value '3209' in the XML</summary>
        [LxEnumValue("3209")]
        N3209,
        /// <summary>Represents the value '3210' in the XML</summary>
        [LxEnumValue("3210")]
        N3210,
        /// <summary>Represents the value '3211' in the XML</summary>
        [LxEnumValue("3211")]
        N3211,
        /// <summary>Represents the value '3212' in the XML</summary>
        [LxEnumValue("3212")]
        N3212,
        /// <summary>Represents the value '3213' in the XML</summary>
        [LxEnumValue("3213")]
        N3213,
        /// <summary>Represents the value '3214' in the XML</summary>
        [LxEnumValue("3214")]
        N3214,
        /// <summary>Represents the value '3215' in the XML</summary>
        [LxEnumValue("3215")]
        N3215,
        /// <summary>Represents the value '3216' in the XML</summary>
        [LxEnumValue("3216")]
        N3216,
        /// <summary>Represents the value '3217' in the XML</summary>
        [LxEnumValue("3217")]
        N3217,
        /// <summary>Represents the value '3218' in the XML</summary>
        [LxEnumValue("3218")]
        N3218,
        /// <summary>Represents the value '3219' in the XML</summary>
        [LxEnumValue("3219")]
        N3219,
        /// <summary>Represents the value '3220' in the XML</summary>
        [LxEnumValue("3220")]
        N3220,
        /// <summary>Represents the value '3271' in the XML</summary>
        [LxEnumValue("3271")]
        N3271,
    }
    /// <summary>An enumeration representing XSD simple type TWybor1_2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podwójne pole wyboru</remarks>
    /// <XsdPath>schema:ElementarneTypyDanych_v...xsd/simpleType:TWybor1_2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>342:2-350:19</XsdLocation>
    public enum TWybor1_2Enum
    {
        /// <summary>Represents the value '1' in the XML</summary>
        [LxEnumValue("1")]
        N1,
        /// <summary>Represents the value '2' in the XML</summary>
        [LxEnumValue("2")]
        N2,
    }
    /// <summary>An enumeration representing XSD simple type TWybor1_3@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Potrójne pole wyboru</remarks>
    /// <XsdPath>schema:ElementarneTypyDanych_v...xsd/simpleType:TWybor1_3</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>351:2-360:19</XsdLocation>
    public enum TWybor1_3Enum
    {
        /// <summary>Represents the value '1' in the XML</summary>
        [LxEnumValue("1")]
        N1,
        /// <summary>Represents the value '2' in the XML</summary>
        [LxEnumValue("2")]
        N2,
        /// <summary>Represents the value '3' in the XML</summary>
        [LxEnumValue("3")]
        N3,
    }
    /// <summary>An enumeration representing XSD simple type TWybor1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pojedyncze pole wyboru</remarks>
    /// <XsdPath>schema:ElementarneTypyDanych_v...xsd/simpleType:TWybor1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>334:2-341:19</XsdLocation>
    public enum TWybor1Enum
    {
        /// <summary>Represents the value '1' in the XML</summary>
        [LxEnumValue("1")]
        N1,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType TAdres1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Dane określające adres - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TAdres1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>18:2-30:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TAdres1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TAdres1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct" />
        /// </summary>
        [LxElementCt("AdresPol", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct AdresPol ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />
        /// </summary>
        [LxElementCt("AdresZagr", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt AdresZagr ;

    }

    /// <summary>A class representing the root XSD complexType TAdres@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Dane określające adres</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TAdres</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>5:2-17:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TAdres", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TAdresCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolskiCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolskiCt" />
        /// </summary>
        [LxElementCt("AdresPol", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TAdresPolskiCt AdresPol ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />
        /// </summary>
        [LxElementCt("AdresZagr", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt AdresZagr ;

    }

    /// <summary>A class representing the root XSD complexType TAdresPolski1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Informacje opisujące adres polski - bez elementu Poczta</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TAdresPolski1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>88:2-139:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TAdresPolski1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TAdresPolski1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum" /> which is fixed (must have the value 'PL')</summary>
        /// <remarks>Kraj</remarks>
        [LxElementValue("KodKraju", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Replace)]
        public LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum KodKraju ; = LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum.PL;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Województwo</remarks>
        [LxElementValue("Wojewodztwo", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Wojewodztwo ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Powiat</remarks>
        [LxElementValue("Powiat", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Powiat ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Gmina</remarks>
        [LxElementValue("Gmina", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Gmina ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Nazwa ulicy</remarks>
        [LxElementValue("Ulica", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "65")]
        public System.String Ulica ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Numer budynku</remarks>
        [LxElementValue("NrDomu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String NrDomu ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer lokalu</remarks>
        [LxElementValue("NrLokalu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String NrLokalu ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwa miejscowości</remarks>
        [LxElementValue("Miejscowosc", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "56")]
        public System.String Miejscowosc ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Kod pocztowy</remarks>
        [LxElementValue("KodPocztowy", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "8")]
        public System.String KodPocztowy ; = "";

    }

    /// <summary>A class representing the root XSD complexType TAdresPolski@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Informacje opisujące adres polski</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TAdresPolski</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>31:2-87:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TAdresPolski", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TAdresPolskiCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum" /> which is fixed (must have the value 'PL')</summary>
        /// <remarks>Kraj</remarks>
        [LxElementValue("KodKraju", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Replace)]
        public LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum KodKraju ; = LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum.PL;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Województwo</remarks>
        [LxElementValue("Wojewodztwo", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Wojewodztwo ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Powiat</remarks>
        [LxElementValue("Powiat", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Powiat ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Gmina</remarks>
        [LxElementValue("Gmina", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String Gmina ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Nazwa ulicy</remarks>
        [LxElementValue("Ulica", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "65")]
        public System.String Ulica ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Numer budynku</remarks>
        [LxElementValue("NrDomu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String NrDomu ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer lokalu</remarks>
        [LxElementValue("NrLokalu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String NrLokalu ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwa miejscowości</remarks>
        [LxElementValue("Miejscowosc", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "56")]
        public System.String Miejscowosc ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Kod pocztowy</remarks>
        [LxElementValue("KodPocztowy", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "8")]
        public System.String KodPocztowy ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwa urzędu pocztowego</remarks>
        [LxElementValue("Poczta", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "56")]
        public System.String Poczta ; = "";

    }

    /// <summary>A class representing the root XSD complexType TAdresZagraniczny@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Informacje opisujące adres zagraniczny</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TAdresZagraniczny</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>140:2-182:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TAdresZagraniczny", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TAdresZagranicznyCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum" />, Required</summary>
        /// <remarks>Kod Kraju [Country Code]</remarks>
        [LxElementValue("KodKraju", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, Pattern = "P[A-KM-Z]")]
        public LiquidXmlObjects.Schemat.Etd.TKodKrajuEnum KodKraju ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Kod pocztowy [Postal code]</remarks>
        [LxElementValue("KodPocztowy", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "8")]
        public System.String KodPocztowy ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwa miejscowości [City]</remarks>
        [LxElementValue("Miejscowosc", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "56")]
        public System.String Miejscowosc ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Nazwa ulicy [Street]</remarks>
        [LxElementValue("Ulica", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "65")]
        public System.String Ulica ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer budynku [Building number]</remarks>
        [LxElementValue("NrDomu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String NrDomu ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer lokalu [Flat number]</remarks>
        [LxElementValue("NrLokalu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String NrLokalu ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyFizycznej1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie fizycznej z identyfikatorem NIP albo PESEL</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyFizycznej1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>216:2-249:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyFizycznej1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyFizycznej1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy numer PESEL</remarks>
        [LxElementValue("PESEL", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{11}")]
        public System.String PESEL ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pierwsze imię</remarks>
        [LxElementValue("ImiePierwsze", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImiePierwsze ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwisko</remarks>
        [LxElementValue("Nazwisko", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "81")]
        public System.String Nazwisko ; = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data urodzenia</remarks>
        [LxElementValue("DataUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataUrodzenia ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyFizycznej2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie fizycznej z identyfikatorem NIP</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyFizycznej2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>250:2-276:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyFizycznej2", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyFizycznej2Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pierwsze imię</remarks>
        [LxElementValue("ImiePierwsze", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImiePierwsze ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwisko</remarks>
        [LxElementValue("Nazwisko", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "81")]
        public System.String Nazwisko ; = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data urodzenia</remarks>
        [LxElementValue("DataUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataUrodzenia ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyFizycznej@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie fizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyFizycznej</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>184:2-215:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyFizycznej", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyFizycznejCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pierwsze imię</remarks>
        [LxElementValue("ImiePierwsze", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImiePierwsze ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwisko</remarks>
        [LxElementValue("Nazwisko", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "81")]
        public System.String Nazwisko ; = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data urodzenia</remarks>
        [LxElementValue("DataUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataUrodzenia ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy numer PESEL</remarks>
        [LxElementValue("PESEL", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{11}")]
        public System.String PESEL ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyFizycznejPelny@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych identyfikacyjnych o osobie fizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyFizycznejPelny</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>277:2-318:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyFizycznejPelny", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyFizycznejPelnyCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pierwsze imię</remarks>
        [LxElementValue("ImiePierwsze", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImiePierwsze ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwisko</remarks>
        [LxElementValue("Nazwisko", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "81")]
        public System.String Nazwisko ; = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data urodzenia</remarks>
        [LxElementValue("DataUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataUrodzenia ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Imię ojca</remarks>
        [LxElementValue("ImieOjca", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImieOjca ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Imię matki</remarks>
        [LxElementValue("ImieMatki", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImieMatki ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Identyfikator podatkowy numer PESEL</remarks>
        [LxElementValue("PESEL", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "\\d{11}")]
        public System.String PESEL ; = "";

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyFizycznejZagranicznej@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Zestaw danych identyfikacyjnych dla osoby fizycznej zagranicznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyFizycznejZagranicznej</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>319:2-360:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyFizycznejZagranicznej", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyFizycznejZagranicznejCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Imię pierwsze [First name]</remarks>
        [LxElementValue("ImiePierwsze", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImiePierwsze ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Nazwisko [Family name]</remarks>
        [LxElementValue("Nazwisko", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "81")]
        public System.String Nazwisko ; = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data urodzenia [Date of Birth]</remarks>
        [LxElementValue("DataUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataUrodzenia ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Miejsce urodzenia [Place of Birth]</remarks>
        [LxElementValue("MiejsceUrodzenia", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "56")]
        public System.String MiejsceUrodzenia ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Imię ojca [Father’s name]</remarks>
        [LxElementValue("ImieOjca", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImieOjca ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Imię matki [Mother’s name]</remarks>
        [LxElementValue("ImieMatki", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String ImieMatki ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP [Tax Identification Number (NIP)]</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyNiefizycznej1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie niefizycznej  - bez elementu Numer REGON</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyNiefizycznej1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>389:2-411:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyNiefizycznej1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyNiefizycznej1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pełna nazwa</remarks>
        [LxElementValue("PelnaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "240")]
        public System.String PelnaNazwa ; = "";

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyNiefizycznej@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyNiefizycznej</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>361:2-388:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyNiefizycznej", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyNiefizycznejCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pełna nazwa</remarks>
        [LxElementValue("PelnaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "240")]
        public System.String PelnaNazwa ; = "";

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Ns.TNrREGONUnion" />, Optional : null when not set</summary>
        /// <remarks>Numer REGON</remarks>
        [LxElementValue("REGON", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Union, XsdType.Union, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Ns.TNrREGONUnion REGON ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyNiefizycznejPelny@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych identyfikacyjnych o osobie niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyNiefizycznejPelny</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>412:2-450:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyNiefizycznejPelny", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyNiefizycznejPelnyCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pełna nazwa</remarks>
        [LxElementValue("PelnaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "240")]
        public System.String PelnaNazwa ; = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Skrócona nazwa</remarks>
        [LxElementValue("SkroconaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "70")]
        public System.String SkroconaNazwa ; = "";

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Ns.TNrREGONUnion" />, Required : should not be set to null</summary>
        /// <remarks>Numer REGON</remarks>
        [LxElementValue("REGON", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Union, XsdType.Union, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Ns.TNrREGONUnion REGON ;

    }

    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyNiefizycznejZagranicznej@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Zestaw danych identyfikacyjnych dla osoby niefizycznej zagranicznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TIdentyfikatorOsobyNiefizycznejZagranicznej</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>451:2-484:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyNiefizycznejZagranicznej", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TIdentyfikatorOsobyNiefizycznejZagranicznejCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pełna nazwa [Name]</remarks>
        [LxElementValue("PelnaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "240")]
        public System.String PelnaNazwa ; = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Nazwa skrócona [Short Name]</remarks>
        [LxElementValue("SkroconaNazwa", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "70")]
        public System.String SkroconaNazwa ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP [Tax Identification Number (NIP)]</remarks>
        [LxElementValue("NIP", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej z identyfikatorem NIP albo PESEL</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>540:2-556:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizyczna1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna1Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna1Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna1Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna1/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>546:4-554:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna1/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>550:8-550:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej z identyfikatorem NIP</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>591:2-607:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna2", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizyczna2Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna2Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna2Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna2Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna2/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>597:4-605:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna2/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>601:8-601:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna3@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej z identyfikatorem NIP albo PESEL - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna3</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>574:2-590:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna3", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizyczna3Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna3Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna3Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna3Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna3/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>580:4-588:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna3/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>584:8-584:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna4@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej z identyfikatorem NIP - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna4</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>659:2-675:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna4", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizyczna4Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna4Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna4Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna4Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna4/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>665:4-673:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna4/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>669:8-669:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna5@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna5</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>557:2-573:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna5", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizyczna5Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna5Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna5Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizyczna5Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna5/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>563:4-571:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna5/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>567:8-567:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizyczna@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>523:2-539:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizycznaCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaCt.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaCt.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaCt.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>529:4-537:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizyczna/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>533:8-533:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizycznaPelna1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o osobie fizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>714:2-730:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizycznaPelna1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizycznaPelna1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelna1Ct.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelna1Ct.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelna1Ct.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna1/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>720:4-728:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna1/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>724:8-724:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaFizycznaPelna@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o osobie fizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>697:2-713:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaFizycznaPelna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaFizycznaPelnaCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt OsobaFizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelnaCt.AdresZamieszkaniaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelnaCt.AdresZamieszkaniaElm AdresZamieszkania ; = new LiquidXmlObjects.Schemat.Etd.TOsobaFizycznaPelnaCt.AdresZamieszkaniaElm();

        /// <summary>Represent the inline xs:element AdresZamieszkania@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna/sequence/element:AdresZamieszkania</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>703:4-711:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkania", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaFizycznaPelna/sequence/element:AdresZamieszkania/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>707:8-707:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaNiefizyczna1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie niefizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>625:2-641:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaNiefizyczna1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaNiefizyczna1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt OsobaNiefizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna1Ct.AdresSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna1Ct.AdresSiedzibyElm AdresSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna1Ct.AdresSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna1/sequence/element:AdresSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>631:4-639:18</XsdLocation>
        [LxSimpleElementDefinition("AdresSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna1/sequence/element:AdresSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>635:8-635:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaNiefizyczna2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie niefizycznej - bez elementu Numer REGON oraz bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>642:2-658:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaNiefizyczna2", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaNiefizyczna2Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct OsobaNiefizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna2Ct.AdresSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna2Ct.AdresSiedzibyElm AdresSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TOsobaNiefizyczna2Ct.AdresSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna2/sequence/element:AdresSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>648:4-656:18</XsdLocation>
        [LxSimpleElementDefinition("AdresSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna2/sequence/element:AdresSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>652:8-652:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaNiefizyczna@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>608:2-624:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaNiefizycznaCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt OsobaNiefizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaCt.AdresSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaCt.AdresSiedzibyElm AdresSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaCt.AdresSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna/sequence/element:AdresSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>614:4-622:18</XsdLocation>
        [LxSimpleElementDefinition("AdresSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizyczna/sequence/element:AdresSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>618:8-618:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaNiefizycznaPelna1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o osobie niefizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>828:2-844:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaNiefizycznaPelna1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaNiefizycznaPelna1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt OsobaNiefizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelna1Ct.AdresSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelna1Ct.AdresSiedzibyElm AdresSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelna1Ct.AdresSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna1/sequence/element:AdresSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>834:4-842:18</XsdLocation>
        [LxSimpleElementDefinition("AdresSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna1/sequence/element:AdresSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>838:8-838:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TOsobaNiefizycznaPelna@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>771:2-787:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TOsobaNiefizycznaPelna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TOsobaNiefizycznaPelnaCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt OsobaNiefizyczna ; = new LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelnaCt.AdresSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelnaCt.AdresSiedzibyElm AdresSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TOsobaNiefizycznaPelnaCt.AdresSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna/sequence/element:AdresSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>777:4-785:18</XsdLocation>
        [LxSimpleElementDefinition("AdresSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TOsobaNiefizycznaPelna/sequence/element:AdresSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>781:8-781:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolny1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej lub niefizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>731:2-750:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolny1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolny1Ct : LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyBezAdresuCt
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny1Ct.AdresZamieszkaniaSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny1Ct.AdresZamieszkaniaSiedzibyElm AdresZamieszkaniaSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny1Ct.AdresZamieszkaniaSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresZamieszkaniaSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny1/sequence/element:AdresZamieszkaniaSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>738:6-746:20</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkaniaSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny1/sequence/element:AdresZamieszkaniaSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>742:10-742:91</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolny2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej lub niefizycznej - bez elementu Numer REGON oraz bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>751:2-770:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolny2", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolny2Ct : LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyBezAdresu3Ct
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny2Ct.AdresZamieszkaniaSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny2Ct.AdresZamieszkaniaSiedzibyElm AdresZamieszkaniaSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TPodmiotDowolny2Ct.AdresZamieszkaniaSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresZamieszkaniaSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny2/sequence/element:AdresZamieszkaniaSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>758:6-766:20</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkaniaSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny2/sequence/element:AdresZamieszkaniaSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>762:10-762:91</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyBezAdresu1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Skrócony zestaw danych o osobie fizycznej lub niefizycznej z identyfikatorem NIP albo PESEL</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyBezAdresu1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>495:2-503:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyBezAdresu1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyBezAdresu1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej1Ct OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt OsobaNiefizyczna ;

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyBezAdresu2@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Skrócony zestaw danych o osobie fizycznej lub niefizycznej z identyfikatorem NIP</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyBezAdresu2</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>504:2-512:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyBezAdresu2", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyBezAdresu2Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt OsobaNiefizyczna ;

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyBezAdresu3@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Skrócony zestaw danych o osobie fizycznej lub niefizycznej z identyfikatorem NIP - bez elementu numer REGON dla osoby niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyBezAdresu3</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>513:2-521:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyBezAdresu3", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyBezAdresu3Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznej2Ct OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznej1Ct OsobaNiefizyczna ;

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyBezAdresu@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Skrócony zestaw danych o osobie fizycznej lub niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyBezAdresu</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>486:2-494:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyBezAdresu", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyBezAdresuCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejCt OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejCt OsobaNiefizyczna ;

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolny@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Podstawowy zestaw danych o osobie fizycznej lub niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>677:2-696:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolny", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyCt : LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyBezAdresuCt
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyCt.AdresZamieszkaniaSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyCt.AdresZamieszkaniaSiedzibyElm AdresZamieszkaniaSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyCt.AdresZamieszkaniaSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresZamieszkaniaSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny/sequence/element:AdresZamieszkaniaSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>684:6-692:20</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkaniaSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolny/sequence/element:AdresZamieszkaniaSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>688:10-688:91</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyPelny1@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o osobie fizycznej lub niefizycznej - bez elementu Poczta w adresie polskim</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny1</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>808:2-827:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyPelny1", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyPelny1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt OsobaNiefizyczna ;

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelny1Ct.AdresZamieszkaniaSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelny1Ct.AdresZamieszkaniaSiedzibyElm AdresZamieszkaniaSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelny1Ct.AdresZamieszkaniaSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresZamieszkaniaSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny1/sequence/element:AdresZamieszkaniaSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>817:4-825:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkaniaSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdres1Ct
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny1/sequence/element:AdresZamieszkaniaSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>821:8-821:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    /// <summary>A class representing the root XSD complexType TPodmiotDowolnyPelny@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Pełny zestaw danych o osobie fizycznej lub niefizycznej</remarks>
    /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>788:2-807:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TPodmiotDowolnyPelny", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/")]
    public partial class TPodmiotDowolnyPelnyCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaFizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyFizycznejPelnyCt OsobaFizyczna ;

        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt" />
        /// </summary>
        [LxElementCt("OsobaNiefizyczna", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TIdentyfikatorOsobyNiefizycznejPelnyCt OsobaNiefizyczna ;

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelnyCt.AdresZamieszkaniaSiedzibyElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelnyCt.AdresZamieszkaniaSiedzibyElm AdresZamieszkaniaSiedziby ; = new LiquidXmlObjects.Schemat.Etd.TPodmiotDowolnyPelnyCt.AdresZamieszkaniaSiedzibyElm();

        /// <summary>Represent the inline xs:element AdresZamieszkaniaSiedziby@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/.</summary>
        /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny/sequence/element:AdresZamieszkaniaSiedziby</XsdPath>
        /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
        /// <XsdLocation>797:4-805:18</XsdLocation>
        [LxSimpleElementDefinition("AdresZamieszkaniaSiedziby", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/", ElementScopeType.InlineElement)]
        public partial class AdresZamieszkaniaSiedzibyElm : LiquidXmlObjects.Schemat.Etd.TAdresCt
        {
            /// <summary>The value for the attribute rodzajAdresu</summary>
            /// <XsdPath>schema:StrukturyDanych_v5-0E.xsd/complexType:TPodmiotDowolnyPelny/sequence/element:AdresZamieszkaniaSiedziby/attribute:rodzajAdresu</XsdPath>
            /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/StrukturyDanych_v5-0E.xsd</XsdFile>
            /// <XsdLocation>801:8-801:89</XsdLocation>
            [LxAttribute("rodzajAdresu", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String RodzajAdresu ; = "RAD";

        }

    }

    #endregion

}

namespace LiquidXmlObjects.Schemat.Tns
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type TCelZlozenia@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Określenie celu złożenia JPK</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/simpleType:TCelZlozenia</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>1131:2-1142:19</XsdLocation>
    public enum TCelZlozeniaEnum
    {
        /// <summary>Represents the value '1' in the XML</summary>
        [LxEnumValue("1")]
        N1,
    }
    /// <summary>An enumeration representing XSD simple type TKodFormularza@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Symbol wzoru formularza</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/simpleType:TKodFormularza</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>1123:2-1130:19</XsdLocation>
    public enum TKodFormularzaEnum
    {
        /// <summary>Represents the value 'JPK_FA' in the XML</summary>
        [LxEnumValue("JPK_FA")]
        JPK_FA,
    }
    /// <summary>An enumeration representing XSD simple type TKodWaluty@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Słownik kodów walut</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/simpleType:TKodWaluty</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>4:2-970:19</XsdLocation>
    public enum TKodWalutyEnum
    {
        /// <summary>Represents the value 'AED' in the XML</summary>
        [LxEnumValue("AED")]
        AED,
        /// <summary>Represents the value 'AFN' in the XML</summary>
        [LxEnumValue("AFN")]
        AFN,
        /// <summary>Represents the value 'ALL' in the XML</summary>
        [LxEnumValue("ALL")]
        ALL,
        /// <summary>Represents the value 'AMD' in the XML</summary>
        [LxEnumValue("AMD")]
        AMD,
        /// <summary>Represents the value 'ANG' in the XML</summary>
        [LxEnumValue("ANG")]
        ANG,
        /// <summary>Represents the value 'AOA' in the XML</summary>
        [LxEnumValue("AOA")]
        AOA,
        /// <summary>Represents the value 'ARS' in the XML</summary>
        [LxEnumValue("ARS")]
        ARS,
        /// <summary>Represents the value 'AUD' in the XML</summary>
        [LxEnumValue("AUD")]
        AUD,
        /// <summary>Represents the value 'AWG' in the XML</summary>
        [LxEnumValue("AWG")]
        AWG,
        /// <summary>Represents the value 'AZN' in the XML</summary>
        [LxEnumValue("AZN")]
        AZN,
        /// <summary>Represents the value 'BAM' in the XML</summary>
        [LxEnumValue("BAM")]
        BAM,
        /// <summary>Represents the value 'BBD' in the XML</summary>
        [LxEnumValue("BBD")]
        BBD,
        /// <summary>Represents the value 'BDT' in the XML</summary>
        [LxEnumValue("BDT")]
        BDT,
        /// <summary>Represents the value 'BGN' in the XML</summary>
        [LxEnumValue("BGN")]
        BGN,
        /// <summary>Represents the value 'BHD' in the XML</summary>
        [LxEnumValue("BHD")]
        BHD,
        /// <summary>Represents the value 'BIF' in the XML</summary>
        [LxEnumValue("BIF")]
        BIF,
        /// <summary>Represents the value 'BMD' in the XML</summary>
        [LxEnumValue("BMD")]
        BMD,
        /// <summary>Represents the value 'BND' in the XML</summary>
        [LxEnumValue("BND")]
        BND,
        /// <summary>Represents the value 'BOB' in the XML</summary>
        [LxEnumValue("BOB")]
        BOB,
        /// <summary>Represents the value 'BOV' in the XML</summary>
        [LxEnumValue("BOV")]
        BOV,
        /// <summary>Represents the value 'BRL' in the XML</summary>
        [LxEnumValue("BRL")]
        BRL,
        /// <summary>Represents the value 'BSD' in the XML</summary>
        [LxEnumValue("BSD")]
        BSD,
        /// <summary>Represents the value 'BTN' in the XML</summary>
        [LxEnumValue("BTN")]
        BTN,
        /// <summary>Represents the value 'BWP' in the XML</summary>
        [LxEnumValue("BWP")]
        BWP,
        /// <summary>Represents the value 'BYN' in the XML</summary>
        [LxEnumValue("BYN")]
        BYN,
        /// <summary>Represents the value 'BYR' in the XML</summary>
        [LxEnumValue("BYR")]
        BYR,
        /// <summary>Represents the value 'BZD' in the XML</summary>
        [LxEnumValue("BZD")]
        BZD,
        /// <summary>Represents the value 'CAD' in the XML</summary>
        [LxEnumValue("CAD")]
        CAD,
        /// <summary>Represents the value 'CDF' in the XML</summary>
        [LxEnumValue("CDF")]
        CDF,
        /// <summary>Represents the value 'CHE' in the XML</summary>
        [LxEnumValue("CHE")]
        CHE,
        /// <summary>Represents the value 'CHF' in the XML</summary>
        [LxEnumValue("CHF")]
        CHF,
        /// <summary>Represents the value 'CHW' in the XML</summary>
        [LxEnumValue("CHW")]
        CHW,
        /// <summary>Represents the value 'CLF' in the XML</summary>
        [LxEnumValue("CLF")]
        CLF,
        /// <summary>Represents the value 'CLP' in the XML</summary>
        [LxEnumValue("CLP")]
        CLP,
        /// <summary>Represents the value 'CNY' in the XML</summary>
        [LxEnumValue("CNY")]
        CNY,
        /// <summary>Represents the value 'COP' in the XML</summary>
        [LxEnumValue("COP")]
        COP,
        /// <summary>Represents the value 'COU' in the XML</summary>
        [LxEnumValue("COU")]
        COU,
        /// <summary>Represents the value 'CRC' in the XML</summary>
        [LxEnumValue("CRC")]
        CRC,
        /// <summary>Represents the value 'CUC' in the XML</summary>
        [LxEnumValue("CUC")]
        CUC,
        /// <summary>Represents the value 'CUP' in the XML</summary>
        [LxEnumValue("CUP")]
        CUP,
        /// <summary>Represents the value 'CVE' in the XML</summary>
        [LxEnumValue("CVE")]
        CVE,
        /// <summary>Represents the value 'CZK' in the XML</summary>
        [LxEnumValue("CZK")]
        CZK,
        /// <summary>Represents the value 'DJF' in the XML</summary>
        [LxEnumValue("DJF")]
        DJF,
        /// <summary>Represents the value 'DKK' in the XML</summary>
        [LxEnumValue("DKK")]
        DKK,
        /// <summary>Represents the value 'DOP' in the XML</summary>
        [LxEnumValue("DOP")]
        DOP,
        /// <summary>Represents the value 'DZD' in the XML</summary>
        [LxEnumValue("DZD")]
        DZD,
        /// <summary>Represents the value 'EEK' in the XML</summary>
        [LxEnumValue("EEK")]
        EEK,
        /// <summary>Represents the value 'EGP' in the XML</summary>
        [LxEnumValue("EGP")]
        EGP,
        /// <summary>Represents the value 'ERN' in the XML</summary>
        [LxEnumValue("ERN")]
        ERN,
        /// <summary>Represents the value 'ETB' in the XML</summary>
        [LxEnumValue("ETB")]
        ETB,
        /// <summary>Represents the value 'EUR' in the XML</summary>
        [LxEnumValue("EUR")]
        EUR,
        /// <summary>Represents the value 'FJD' in the XML</summary>
        [LxEnumValue("FJD")]
        FJD,
        /// <summary>Represents the value 'FKP' in the XML</summary>
        [LxEnumValue("FKP")]
        FKP,
        /// <summary>Represents the value 'GBP' in the XML</summary>
        [LxEnumValue("GBP")]
        GBP,
        /// <summary>Represents the value 'GEL' in the XML</summary>
        [LxEnumValue("GEL")]
        GEL,
        /// <summary>Represents the value 'GGP' in the XML</summary>
        [LxEnumValue("GGP")]
        GGP,
        /// <summary>Represents the value 'GHS' in the XML</summary>
        [LxEnumValue("GHS")]
        GHS,
        /// <summary>Represents the value 'GIP' in the XML</summary>
        [LxEnumValue("GIP")]
        GIP,
        /// <summary>Represents the value 'GMD' in the XML</summary>
        [LxEnumValue("GMD")]
        GMD,
        /// <summary>Represents the value 'GNF' in the XML</summary>
        [LxEnumValue("GNF")]
        GNF,
        /// <summary>Represents the value 'GTQ' in the XML</summary>
        [LxEnumValue("GTQ")]
        GTQ,
        /// <summary>Represents the value 'GWP' in the XML</summary>
        [LxEnumValue("GWP")]
        GWP,
        /// <summary>Represents the value 'GYD' in the XML</summary>
        [LxEnumValue("GYD")]
        GYD,
        /// <summary>Represents the value 'HKD' in the XML</summary>
        [LxEnumValue("HKD")]
        HKD,
        /// <summary>Represents the value 'HNL' in the XML</summary>
        [LxEnumValue("HNL")]
        HNL,
        /// <summary>Represents the value 'HRK' in the XML</summary>
        [LxEnumValue("HRK")]
        HRK,
        /// <summary>Represents the value 'HTG' in the XML</summary>
        [LxEnumValue("HTG")]
        HTG,
        /// <summary>Represents the value 'HUF' in the XML</summary>
        [LxEnumValue("HUF")]
        HUF,
        /// <summary>Represents the value 'IDR' in the XML</summary>
        [LxEnumValue("IDR")]
        IDR,
        /// <summary>Represents the value 'ILS' in the XML</summary>
        [LxEnumValue("ILS")]
        ILS,
        /// <summary>Represents the value 'IMP' in the XML</summary>
        [LxEnumValue("IMP")]
        IMP,
        /// <summary>Represents the value 'INR' in the XML</summary>
        [LxEnumValue("INR")]
        INR,
        /// <summary>Represents the value 'IQD' in the XML</summary>
        [LxEnumValue("IQD")]
        IQD,
        /// <summary>Represents the value 'IRR' in the XML</summary>
        [LxEnumValue("IRR")]
        IRR,
        /// <summary>Represents the value 'ISK' in the XML</summary>
        [LxEnumValue("ISK")]
        ISK,
        /// <summary>Represents the value 'JEP' in the XML</summary>
        [LxEnumValue("JEP")]
        JEP,
        /// <summary>Represents the value 'JMD' in the XML</summary>
        [LxEnumValue("JMD")]
        JMD,
        /// <summary>Represents the value 'JOD' in the XML</summary>
        [LxEnumValue("JOD")]
        JOD,
        /// <summary>Represents the value 'JPY' in the XML</summary>
        [LxEnumValue("JPY")]
        JPY,
        /// <summary>Represents the value 'KES' in the XML</summary>
        [LxEnumValue("KES")]
        KES,
        /// <summary>Represents the value 'KGS' in the XML</summary>
        [LxEnumValue("KGS")]
        KGS,
        /// <summary>Represents the value 'KHR' in the XML</summary>
        [LxEnumValue("KHR")]
        KHR,
        /// <summary>Represents the value 'KMF' in the XML</summary>
        [LxEnumValue("KMF")]
        KMF,
        /// <summary>Represents the value 'KPW' in the XML</summary>
        [LxEnumValue("KPW")]
        KPW,
        /// <summary>Represents the value 'KRW' in the XML</summary>
        [LxEnumValue("KRW")]
        KRW,
        /// <summary>Represents the value 'KWD' in the XML</summary>
        [LxEnumValue("KWD")]
        KWD,
        /// <summary>Represents the value 'KYD' in the XML</summary>
        [LxEnumValue("KYD")]
        KYD,
        /// <summary>Represents the value 'KZT' in the XML</summary>
        [LxEnumValue("KZT")]
        KZT,
        /// <summary>Represents the value 'LAK' in the XML</summary>
        [LxEnumValue("LAK")]
        LAK,
        /// <summary>Represents the value 'LBP' in the XML</summary>
        [LxEnumValue("LBP")]
        LBP,
        /// <summary>Represents the value 'LKR' in the XML</summary>
        [LxEnumValue("LKR")]
        LKR,
        /// <summary>Represents the value 'LRD' in the XML</summary>
        [LxEnumValue("LRD")]
        LRD,
        /// <summary>Represents the value 'LSL' in the XML</summary>
        [LxEnumValue("LSL")]
        LSL,
        /// <summary>Represents the value 'LTL' in the XML</summary>
        [LxEnumValue("LTL")]
        LTL,
        /// <summary>Represents the value 'LVL' in the XML</summary>
        [LxEnumValue("LVL")]
        LVL,
        /// <summary>Represents the value 'LYD' in the XML</summary>
        [LxEnumValue("LYD")]
        LYD,
        /// <summary>Represents the value 'MAD' in the XML</summary>
        [LxEnumValue("MAD")]
        MAD,
        /// <summary>Represents the value 'MDL' in the XML</summary>
        [LxEnumValue("MDL")]
        MDL,
        /// <summary>Represents the value 'MGA' in the XML</summary>
        [LxEnumValue("MGA")]
        MGA,
        /// <summary>Represents the value 'MKD' in the XML</summary>
        [LxEnumValue("MKD")]
        MKD,
        /// <summary>Represents the value 'MMK' in the XML</summary>
        [LxEnumValue("MMK")]
        MMK,
        /// <summary>Represents the value 'MNT' in the XML</summary>
        [LxEnumValue("MNT")]
        MNT,
        /// <summary>Represents the value 'MOP' in the XML</summary>
        [LxEnumValue("MOP")]
        MOP,
        /// <summary>Represents the value 'MRO' in the XML</summary>
        [LxEnumValue("MRO")]
        MRO,
        /// <summary>Represents the value 'MRU' in the XML</summary>
        [LxEnumValue("MRU")]
        MRU,
        /// <summary>Represents the value 'MTL' in the XML</summary>
        [LxEnumValue("MTL")]
        MTL,
        /// <summary>Represents the value 'MUR' in the XML</summary>
        [LxEnumValue("MUR")]
        MUR,
        /// <summary>Represents the value 'MVR' in the XML</summary>
        [LxEnumValue("MVR")]
        MVR,
        /// <summary>Represents the value 'MWK' in the XML</summary>
        [LxEnumValue("MWK")]
        MWK,
        /// <summary>Represents the value 'MXN' in the XML</summary>
        [LxEnumValue("MXN")]
        MXN,
        /// <summary>Represents the value 'MXV' in the XML</summary>
        [LxEnumValue("MXV")]
        MXV,
        /// <summary>Represents the value 'MYR' in the XML</summary>
        [LxEnumValue("MYR")]
        MYR,
        /// <summary>Represents the value 'MZN' in the XML</summary>
        [LxEnumValue("MZN")]
        MZN,
        /// <summary>Represents the value 'NAD' in the XML</summary>
        [LxEnumValue("NAD")]
        NAD,
        /// <summary>Represents the value 'NGN' in the XML</summary>
        [LxEnumValue("NGN")]
        NGN,
        /// <summary>Represents the value 'NIO' in the XML</summary>
        [LxEnumValue("NIO")]
        NIO,
        /// <summary>Represents the value 'NOK' in the XML</summary>
        [LxEnumValue("NOK")]
        NOK,
        /// <summary>Represents the value 'NPR' in the XML</summary>
        [LxEnumValue("NPR")]
        NPR,
        /// <summary>Represents the value 'NZD' in the XML</summary>
        [LxEnumValue("NZD")]
        NZD,
        /// <summary>Represents the value 'OMR' in the XML</summary>
        [LxEnumValue("OMR")]
        OMR,
        /// <summary>Represents the value 'PAB' in the XML</summary>
        [LxEnumValue("PAB")]
        PAB,
        /// <summary>Represents the value 'PEN' in the XML</summary>
        [LxEnumValue("PEN")]
        PEN,
        /// <summary>Represents the value 'PGK' in the XML</summary>
        [LxEnumValue("PGK")]
        PGK,
        /// <summary>Represents the value 'PHP' in the XML</summary>
        [LxEnumValue("PHP")]
        PHP,
        /// <summary>Represents the value 'PKR' in the XML</summary>
        [LxEnumValue("PKR")]
        PKR,
        /// <summary>Represents the value 'PLN' in the XML</summary>
        [LxEnumValue("PLN")]
        PLN,
        /// <summary>Represents the value 'PYG' in the XML</summary>
        [LxEnumValue("PYG")]
        PYG,
        /// <summary>Represents the value 'QAR' in the XML</summary>
        [LxEnumValue("QAR")]
        QAR,
        /// <summary>Represents the value 'RON' in the XML</summary>
        [LxEnumValue("RON")]
        RON,
        /// <summary>Represents the value 'RSD' in the XML</summary>
        [LxEnumValue("RSD")]
        RSD,
        /// <summary>Represents the value 'RUB' in the XML</summary>
        [LxEnumValue("RUB")]
        RUB,
        /// <summary>Represents the value 'RWF' in the XML</summary>
        [LxEnumValue("RWF")]
        RWF,
        /// <summary>Represents the value 'SAR' in the XML</summary>
        [LxEnumValue("SAR")]
        SAR,
        /// <summary>Represents the value 'SBD' in the XML</summary>
        [LxEnumValue("SBD")]
        SBD,
        /// <summary>Represents the value 'SCR' in the XML</summary>
        [LxEnumValue("SCR")]
        SCR,
        /// <summary>Represents the value 'SDG' in the XML</summary>
        [LxEnumValue("SDG")]
        SDG,
        /// <summary>Represents the value 'SEK' in the XML</summary>
        [LxEnumValue("SEK")]
        SEK,
        /// <summary>Represents the value 'SGD' in the XML</summary>
        [LxEnumValue("SGD")]
        SGD,
        /// <summary>Represents the value 'SHP' in the XML</summary>
        [LxEnumValue("SHP")]
        SHP,
        /// <summary>Represents the value 'SLL' in the XML</summary>
        [LxEnumValue("SLL")]
        SLL,
        /// <summary>Represents the value 'SOS' in the XML</summary>
        [LxEnumValue("SOS")]
        SOS,
        /// <summary>Represents the value 'SRD' in the XML</summary>
        [LxEnumValue("SRD")]
        SRD,
        /// <summary>Represents the value 'SSP' in the XML</summary>
        [LxEnumValue("SSP")]
        SSP,
        /// <summary>Represents the value 'STD' in the XML</summary>
        [LxEnumValue("STD")]
        STD,
        /// <summary>Represents the value 'STN' in the XML</summary>
        [LxEnumValue("STN")]
        STN,
        /// <summary>Represents the value 'SVC' in the XML</summary>
        [LxEnumValue("SVC")]
        SVC,
        /// <summary>Represents the value 'SYP' in the XML</summary>
        [LxEnumValue("SYP")]
        SYP,
        /// <summary>Represents the value 'SZL' in the XML</summary>
        [LxEnumValue("SZL")]
        SZL,
        /// <summary>Represents the value 'THB' in the XML</summary>
        [LxEnumValue("THB")]
        THB,
        /// <summary>Represents the value 'TJS' in the XML</summary>
        [LxEnumValue("TJS")]
        TJS,
        /// <summary>Represents the value 'TMT' in the XML</summary>
        [LxEnumValue("TMT")]
        TMT,
        /// <summary>Represents the value 'TND' in the XML</summary>
        [LxEnumValue("TND")]
        TND,
        /// <summary>Represents the value 'TOP' in the XML</summary>
        [LxEnumValue("TOP")]
        TOP,
        /// <summary>Represents the value 'TRY' in the XML</summary>
        [LxEnumValue("TRY")]
        TRY_,
        /// <summary>Represents the value 'TTD' in the XML</summary>
        [LxEnumValue("TTD")]
        TTD,
        /// <summary>Represents the value 'TWD' in the XML</summary>
        [LxEnumValue("TWD")]
        TWD,
        /// <summary>Represents the value 'TZS' in the XML</summary>
        [LxEnumValue("TZS")]
        TZS,
        /// <summary>Represents the value 'UAH' in the XML</summary>
        [LxEnumValue("UAH")]
        UAH,
        /// <summary>Represents the value 'UGX' in the XML</summary>
        [LxEnumValue("UGX")]
        UGX,
        /// <summary>Represents the value 'USD' in the XML</summary>
        [LxEnumValue("USD")]
        USD,
        /// <summary>Represents the value 'USN' in the XML</summary>
        [LxEnumValue("USN")]
        USN,
        /// <summary>Represents the value 'USS' in the XML</summary>
        [LxEnumValue("USS")]
        USS,
        /// <summary>Represents the value 'UYI' in the XML</summary>
        [LxEnumValue("UYI")]
        UYI,
        /// <summary>Represents the value 'UYU' in the XML</summary>
        [LxEnumValue("UYU")]
        UYU,
        /// <summary>Represents the value 'UYW' in the XML</summary>
        [LxEnumValue("UYW")]
        UYW,
        /// <summary>Represents the value 'UZS' in the XML</summary>
        [LxEnumValue("UZS")]
        UZS,
        /// <summary>Represents the value 'VEF' in the XML</summary>
        [LxEnumValue("VEF")]
        VEF,
        /// <summary>Represents the value 'VES' in the XML</summary>
        [LxEnumValue("VES")]
        VES,
        /// <summary>Represents the value 'VND' in the XML</summary>
        [LxEnumValue("VND")]
        VND,
        /// <summary>Represents the value 'VUV' in the XML</summary>
        [LxEnumValue("VUV")]
        VUV,
        /// <summary>Represents the value 'WST' in the XML</summary>
        [LxEnumValue("WST")]
        WST,
        /// <summary>Represents the value 'XAF' in the XML</summary>
        [LxEnumValue("XAF")]
        XAF,
        /// <summary>Represents the value 'XAG' in the XML</summary>
        [LxEnumValue("XAG")]
        XAG,
        /// <summary>Represents the value 'XAU' in the XML</summary>
        [LxEnumValue("XAU")]
        XAU,
        /// <summary>Represents the value 'XBA' in the XML</summary>
        [LxEnumValue("XBA")]
        XBA,
        /// <summary>Represents the value 'XBB' in the XML</summary>
        [LxEnumValue("XBB")]
        XBB,
        /// <summary>Represents the value 'XBC' in the XML</summary>
        [LxEnumValue("XBC")]
        XBC,
        /// <summary>Represents the value 'XBD' in the XML</summary>
        [LxEnumValue("XBD")]
        XBD,
        /// <summary>Represents the value 'XCD' in the XML</summary>
        [LxEnumValue("XCD")]
        XCD,
        /// <summary>Represents the value 'XDR' in the XML</summary>
        [LxEnumValue("XDR")]
        XDR,
        /// <summary>Represents the value 'XFU' in the XML</summary>
        [LxEnumValue("XFU")]
        XFU,
        /// <summary>Represents the value 'XOF' in the XML</summary>
        [LxEnumValue("XOF")]
        XOF,
        /// <summary>Represents the value 'XPD' in the XML</summary>
        [LxEnumValue("XPD")]
        XPD,
        /// <summary>Represents the value 'XPF' in the XML</summary>
        [LxEnumValue("XPF")]
        XPF,
        /// <summary>Represents the value 'XPT' in the XML</summary>
        [LxEnumValue("XPT")]
        XPT,
        /// <summary>Represents the value 'XSU' in the XML</summary>
        [LxEnumValue("XSU")]
        XSU,
        /// <summary>Represents the value 'XUA' in the XML</summary>
        [LxEnumValue("XUA")]
        XUA,
        /// <summary>Represents the value 'XXX' in the XML</summary>
        [LxEnumValue("XXX")]
        XXX,
        /// <summary>Represents the value 'YER' in the XML</summary>
        [LxEnumValue("YER")]
        YER,
        /// <summary>Represents the value 'ZAR' in the XML</summary>
        [LxEnumValue("ZAR")]
        ZAR,
        /// <summary>Represents the value 'ZMW' in the XML</summary>
        [LxEnumValue("ZMW")]
        ZMW,
        /// <summary>Represents the value 'ZWL' in the XML</summary>
        [LxEnumValue("ZWL")]
        ZWL,
    }
    /// <summary>An enumeration representing XSD simple type TKodyKrajowUE@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Kody krajów członkowskich Unii Europejskiej, w tym kod dla obszaru Irlandii Północnej</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/simpleType:TKodyKrajowUE</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>971:2-1122:19</XsdLocation>
    public enum TKodyKrajowUEEnum
    {
        /// <summary>Represents the value 'AT' in the XML</summary>
        [LxEnumValue("AT")]
        AT,
        /// <summary>Represents the value 'BE' in the XML</summary>
        [LxEnumValue("BE")]
        BE,
        /// <summary>Represents the value 'BG' in the XML</summary>
        [LxEnumValue("BG")]
        BG,
        /// <summary>Represents the value 'CY' in the XML</summary>
        [LxEnumValue("CY")]
        CY,
        /// <summary>Represents the value 'CZ' in the XML</summary>
        [LxEnumValue("CZ")]
        CZ,
        /// <summary>Represents the value 'DK' in the XML</summary>
        [LxEnumValue("DK")]
        DK,
        /// <summary>Represents the value 'EE' in the XML</summary>
        [LxEnumValue("EE")]
        EE,
        /// <summary>Represents the value 'FI' in the XML</summary>
        [LxEnumValue("FI")]
        FI,
        /// <summary>Represents the value 'FR' in the XML</summary>
        [LxEnumValue("FR")]
        FR,
        /// <summary>Represents the value 'DE' in the XML</summary>
        [LxEnumValue("DE")]
        DE,
        /// <summary>Represents the value 'EL' in the XML</summary>
        [LxEnumValue("EL")]
        EL,
        /// <summary>Represents the value 'HR' in the XML</summary>
        [LxEnumValue("HR")]
        HR,
        /// <summary>Represents the value 'HU' in the XML</summary>
        [LxEnumValue("HU")]
        HU,
        /// <summary>Represents the value 'IE' in the XML</summary>
        [LxEnumValue("IE")]
        IE,
        /// <summary>Represents the value 'IT' in the XML</summary>
        [LxEnumValue("IT")]
        IT,
        /// <summary>Represents the value 'LV' in the XML</summary>
        [LxEnumValue("LV")]
        LV,
        /// <summary>Represents the value 'LT' in the XML</summary>
        [LxEnumValue("LT")]
        LT,
        /// <summary>Represents the value 'LU' in the XML</summary>
        [LxEnumValue("LU")]
        LU,
        /// <summary>Represents the value 'MT' in the XML</summary>
        [LxEnumValue("MT")]
        MT,
        /// <summary>Represents the value 'NL' in the XML</summary>
        [LxEnumValue("NL")]
        NL,
        /// <summary>Represents the value 'PL' in the XML</summary>
        [LxEnumValue("PL")]
        PL,
        /// <summary>Represents the value 'PT' in the XML</summary>
        [LxEnumValue("PT")]
        PT,
        /// <summary>Represents the value 'RO' in the XML</summary>
        [LxEnumValue("RO")]
        RO,
        /// <summary>Represents the value 'SK' in the XML</summary>
        [LxEnumValue("SK")]
        SK,
        /// <summary>Represents the value 'SI' in the XML</summary>
        [LxEnumValue("SI")]
        SI,
        /// <summary>Represents the value 'ES' in the XML</summary>
        [LxEnumValue("ES")]
        ES,
        /// <summary>Represents the value 'SE' in the XML</summary>
        [LxEnumValue("SE")]
        SE,
        /// <summary>Represents the value 'GB' in the XML</summary>
        [LxEnumValue("GB")]
        GB,
        /// <summary>Represents the value 'XI' in the XML</summary>
        [LxEnumValue("XI")]
        XI,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType TIdentyfikatorOsobyNiefizycznej1@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Podstawowy zestaw danych identyfikacyjnych o osobie niefizycznej - bez elementu Numer REGON, rozszerzony o numery identyfikacyjne dla celów OSS i IOSS</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TIdentyfikatorOsobyNiefizycznej1</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>1188:2-1222:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIdentyfikatorOsobyNiefizycznej1", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/")]
    public partial class TIdentyfikatorOsobyNiefizycznej1Ct : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Identyfikator podatkowy NIP</remarks>
        [LxElementValue("NIP", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, Pattern = "[1-9]((\\d[1-9])|([1-9]\\d))\\d{7}")]
        public System.String NIP ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer identyfikacyjny VAT podatnika w procedurze nieunijnej</remarks>
        [LxElementValue("EUPLVATID", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdNMTOKEN, MinOccurs = 0, MaxOccurs = 1, Pattern = "EU616[0-9]{6}")]
        public System.String EUPLVATID ;

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Numer identyfikacyjny VAT podatnika w procedurze importu, nadany zgodnie z art. 138e ust. 7 pkt 1 i 2 ustawy</remarks>
        [LxElementValue("IMPLVATID", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdNMTOKEN, MinOccurs = 0, MaxOccurs = 1, Pattern = "IM616[0-9]{7}")]
        public System.String IMPLVATID ;

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Pełna nazwa</remarks>
        [LxElementValue("PelnaNazwa", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "240")]
        public System.String PelnaNazwa ; = "";

    }

    /// <summary>A class representing the root XSD complexType TNaglowek@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Nagłówek JPK_FA</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>1143:2-1187:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("TNaglowek", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/")]
    public partial class TNaglowekCt : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.TNaglowekCt.KodFormularzaElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.TNaglowekCt.KodFormularzaElm KodFormularza ; = new LiquidXmlObjects.Schemat.Tns.TNaglowekCt.KodFormularzaElm();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.TNaglowekCt.WariantFormularzaEnum" />, Required</summary>
        [LxElementValue("WariantFormularza", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.TNaglowekCt.WariantFormularzaEnum WariantFormularza ;

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.TCelZlozeniaEnum" />, Required</summary>
        [LxElementValue("CelZlozenia", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.TCelZlozeniaEnum CelZlozenia ;

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data i czas wytworzenia JPK_FA</remarks>
        [LxElementValue("DataWytworzeniaJPK", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse)]
        public LiquidTechnologies.XmlObjects.LxDateTime DataWytworzeniaJPK ;

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data początkowa okresu, którego dotyczy JPK_FA</remarks>
        [LxElementValue("DataOd", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-01-01", MinInclusive = "2016-07-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataOd ;

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Data końcowa okresu, którego dotyczy JPK_FA</remarks>
        [LxElementValue("DataDo", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-01-01", MinInclusive = "2016-07-01")]
        public LiquidTechnologies.XmlObjects.LxDateTime DataDo ;

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Etd.TKodUSEnum" />, Required</summary>
        /// <remarks>Kod urzędu skarbowego, właściwy dla podatnika przekazującego JPK_FA</remarks>
        [LxElementValue("KodUrzedu", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public LiquidXmlObjects.Schemat.Etd.TKodUSEnum KodUrzedu ;

        /// <summary>An enumeration representing XSD simple type WariantFormularza@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek/sequence/element:WariantFormularza</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1158:4-1164:18</XsdLocation>
        public enum WariantFormularzaEnum
        {
            /// <summary>Represents the value '4' in the XML</summary>
            [LxEnumValue("4")]
            N4,
        }
        /// <summary>Represent the inline xs:element KodFormularza@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek/sequence/element:KodFormularza</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1148:4-1157:18</XsdLocation>
        [LxSimpleElementDefinition("KodFormularza", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class KodFormularzaElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>The value for the attribute kodSystemowy</summary>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek/sequence/element:KodFormularza/attribute:kodSystemowy</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1152:8-1152:96</XsdLocation>
            [LxAttribute("kodSystemowy", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String KodSystemowy ; = "JPK_FA (4)";

            /// <summary>The value for the attribute wersjaSchemy</summary>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek/sequence/element:KodFormularza/attribute:wersjaSchemy</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1153:8-1153:89</XsdLocation>
            [LxAttribute("wersjaSchemy", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String WersjaSchemy ; = "1-0";

            /// <summary>Holds the <see cref="LiquidXmlObjects.Schemat.Tns.TKodFormularzaEnum" /> value of the element</summary>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/complexType:TNaglowek/sequence/element:KodFormularza</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1148:4-1157:18</XsdLocation>
            [LxValue(LxValueType.Enum, XsdType.Enum, WhiteSpace = WhiteSpaceType.Preserve)]
            public LiquidXmlObjects.Schemat.Tns.TKodFormularzaEnum Value ;

        }

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element JPK@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
    /// <remarks>Jednolity plik kontrolny dla faktur VAT</remarks>
    /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK</XsdPath>
    /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
    /// <XsdLocation>1304:2-1957:16</XsdLocation>
    [LxSimpleElementDefinition("JPK", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.GlobalElement)]
    public partial class JPKElm : LiquidXmlObjects.Schemat.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Tns.TNaglowekCt" />.<br/>
        ///   By default this would be a <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.NaglowekElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="LiquidXmlObjects.Schemat.Tns.TNaglowekCt" />
        /// </summary>
        /// <remarks>Nagłówek JPK_FA</remarks>
        [LxElementCt("Naglowek", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.TNaglowekCt Naglowek ; = new LiquidXmlObjects.Schemat.Tns.JPKElm.NaglowekElm();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.Podmiot1Elm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.JPKElm.Podmiot1Elm Podmiot1 ; = new LiquidXmlObjects.Schemat.Tns.JPKElm.Podmiot1Elm();

        /// <summary>A collection of <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaElm" /></summary>
        /// <remarks>Na podstawie art. 106a - 106q ustawy. Wartości sprzedaży i kwoty podatku wypełnia się w walucie, w której wystawiono fakturę, z wyjątkiem pól, w których kwoty podatku zostały przeliczone zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy. W przypadku wystawienia faktury korygującej, wypełnia się wszystkie dane wg stanu po korekcie. Dane dotyczące podstaw opodatkowania, kwot podatku oraz kwoty ogółem wypełnia się poprzez różnicę</remarks>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaElm> Faktura { get; } = new List<LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaElm>();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaCtrlElm" />, Required : should not be set to null</summary>
        /// <remarks>Sumy kontrolne dla faktur</remarks>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaCtrlElm FakturaCtrl ; = new LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaCtrlElm();

        /// <summary>A collection of <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszElm" /></summary>
        /// <remarks>Szczegółowe pozycje faktury w walucie, w której wystawiono fakturę - węzeł opcjonalny dla faktury zaliczkowej, faktury korygującej fakturę zaliczkową, oraz faktur korygujących dotyczących wszystkich dostaw towarów lub usług dokonanych lub świadczonych w danym okresie, o których mowa w art. 106j ust. 3 ustawy, dla których należy podać dane dotyczące opustu lub obniżki w podziale na stawki podatku i procedury w sekcji Fa. W przypadku faktur korygujących, o których mowa w art. 106j ust. 3 ustawy, gdy opust lub obniżka ceny odnosi się do części dostaw towarów lub usług dokonanych lub świadczonych w danym okresie w sekcji FakturaWiersz należy podać nazwy (rodzaje) towarów lub usług objętych korektą. W przypadku faktur, o których mowa w art. 106f ust. 3 ustawy należy prezentować pełne wartości zamówienia lub umowy. W przypadku faktur korygujących pozycje faktury (w tym faktur korygujących faktury, o których mowa w art. 106f ust. 3 ustawy, jeśli korekta dotyczy wartości zamówienia) należy prezentować różnice wynikające z korekty poszczególnych pozycji lub storna poszczególnych pozycji korygowanych i prawidłowe wartości korygowanych pozycji jako osobne wiersze. W przypadku faktur korygujących faktury, o których mowa w art. 106f ust. 3 ustawy, jeśli korekta nie dotyczy wartości zamówienia i jednocześnie zmienia wysokość podstawy opodatkowania lub podatku, można wprowadzić zapis stornujący dany wiersz wg stanu przed korektą i zapis przywracający wartość zamówienia w celu potwierdzenia braku zmiany jego wartości</remarks>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszElm> FakturaWiersz { get; } = new List<LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszElm>();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszCtrlElm" />, Required : should not be set to null</summary>
        /// <remarks>Sumy kontrolne dla wierszy faktur</remarks>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszCtrlElm FakturaWierszCtrl ; = new LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszCtrlElm();

        /// <summary>A collection of <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm" /></summary>
        /// <remarks>Zamówienie lub umowa, o których mowa w art. 106f ust. 1 pkt 4 ustawy (dla faktur zaliczkowych) w walucie, w której wystawiono fakturę zaliczkową. W przypadku faktury korygującej fakturę zaliczkową należy prezentować różnice wynikające z korekty poszczególnych pozycji zamówienia lub umowy lub storna poszczególnych korygowanych pozycji zamówienia lub umowy i prawidłowe wartości korygowanych pozycji jako osobne wiersze jeśli korekta dotyczy wartości zamówienia. W przypadku faktur korygujących faktury zaliczkowe, jeśli korekta nie dotyczy wartości zamówienia i jednocześnie zmienia wysokość podstawy opodatkowania lub podatku, można wprowadzić zapis stornujący dany wiersz wg stanu przed korektą i zapis przywracający wartość zamówienia w celu potwierdzenia braku zmiany jego wartości</remarks>
        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm> Zamowienie { get; } = new List<LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm>();

        /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieCtrlElm" />, Optional : null when not set</summary>
        /// <remarks>Sumy kontrolne dla zamówień lub umów</remarks>
        [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
        public LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieCtrlElm ZamowienieCtrl ;

        /// <summary>Represent the inline xs:element Naglowek@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Nagłówek JPK_FA</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:Naglowek</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1310:5-1319:19</XsdLocation>
        [LxSimpleElementDefinition("Naglowek", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class NaglowekElm : LiquidXmlObjects.Schemat.Tns.TNaglowekCt
        {
        }

        /// <summary>Represent the inline xs:element Podmiot1@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:Podmiot1</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1320:5-1342:19</XsdLocation>
        [LxSimpleElementDefinition("Podmiot1", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class Podmiot1Elm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>
            ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Tns.TIdentyfikatorOsobyNiefizycznej1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="LiquidXmlObjects.Schemat.Tns.TIdentyfikatorOsobyNiefizycznej1Ct" />
            /// </summary>
            /// <remarks>Dane identyfikujące podmiot</remarks>
            [LxElementCt("IdentyfikatorPodmiotu", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", MinOccurs = 1, MaxOccurs = 1)]
            public LiquidXmlObjects.Schemat.Tns.TIdentyfikatorOsobyNiefizycznej1Ct IdentyfikatorPodmiotu ; = new LiquidXmlObjects.Schemat.Tns.TIdentyfikatorOsobyNiefizycznej1Ct();

            /// <summary>
            ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct" />
            /// </summary>
            /// <remarks>Adres podmiotu w Polsce</remarks>
            [LxElementCt("AdresPodmiotu", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", MinOccurs = 0, MaxOccurs = 1)]
            public LiquidXmlObjects.Schemat.Etd.TAdresPolski1Ct AdresPodmiotu ;

            /// <summary>
            ///   A class derived from <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />.<br/><br/>
            ///   Allowable types are <br/>
            ///       <see cref="LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt" />
            /// </summary>
            /// <remarks>Adres podmiotu zagraniczny</remarks>
            [LxElementCt("AdresPodmiotu2", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", MinOccurs = 0, MaxOccurs = 1)]
            public LiquidXmlObjects.Schemat.Etd.TAdresZagranicznyCt AdresPodmiotu2 ;

        }

        /// <summary>Represent the inline xs:element Faktura@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Na podstawie art. 106a - 106q ustawy. Wartości sprzedaży i kwoty podatku wypełnia się w walucie, w której wystawiono fakturę, z wyjątkiem pól, w których kwoty podatku zostały przeliczone zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy. W przypadku wystawienia faktury korygującej, wypełnia się wszystkie dane wg stanu po korekcie. Dane dotyczące podstaw opodatkowania, kwot podatku oraz kwoty ogółem wypełnia się poprzez różnicę</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:Faktura</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1343:5-1703:19</XsdLocation>
        [LxSimpleElementDefinition("Faktura", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class FakturaElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.TKodWalutyEnum" />, Required</summary>
            /// <remarks>Trzyliterowy kod waluty (ISO-4217), w której faktura, zamówienie lub umowa zostały wystawione</remarks>
            [LxElementValue("KodWaluty", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Replace)]
            public LiquidXmlObjects.Schemat.Tns.TKodWalutyEnum KodWaluty ;

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
            /// <remarks>Data wystawienia</remarks>
            [LxElementValue("P_1", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-01-01", MinInclusive = "2006-01-01")]
            public LiquidTechnologies.XmlObjects.LxDateTime P_1 ;

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            /// <remarks>Kolejny numer faktury, nadany w ramach jednej lub więcej serii, który w sposób jednoznaczny indentyfikuje fakturę</remarks>
            [LxElementValue("P_2A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_2A ; = "";

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Imię i nazwisko lub nazwa nabywcy towarów lub usług. Pole opcjonalne dla przypadku określonego w art. 106e ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_3A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_3A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Adres nabywcy. Pole opcjonalne dla przypadków określonych w art. 106e ust. 5 pkt 3 ustawy oraz w § 3 pkt 2 i 4 rozporządzenia Ministra Finansów z dnia 3 grudnia 2013 r. w sprawie wystawiania faktur (Dz. U. z 2013 r., poz. 1485), a także § 3 pkt 2 i 4  rozporządzenia Ministra Finansów z dnia 29 października 2021 r. w sprawie wystawiania faktur (Dz. U. z 2021 r., poz. 1979)</remarks>
            [LxElementValue("P_3B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_3B ;

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            /// <remarks>Imię i nazwisko lub nazwa sprzedawcy towarów lub usług</remarks>
            [LxElementValue("P_3C", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_3C ; = "";

            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            /// <remarks>Adres sprzedawcy</remarks>
            [LxElementValue("P_3D", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_3D ; = "";

            /// <summary>A nullable <see cref="LiquidXmlObjects.Schemat.Tns.TKodyKrajowUEEnum" />, Optional : null when not set</summary>
            /// <remarks>Kod (prefiks) podatnika VAT UE dla przypadków określonych w art. 97 ust. 10 pkt 2 i 3 ustawy oraz w przypadku, o którym mowa w art. 136 ust. 1 pkt 3 ustawy</remarks>
            [LxElementValue("P_4A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Replace)]
            public LiquidXmlObjects.Schemat.Tns.TKodyKrajowUEEnum? P_4A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Numer, za pomocą którego podatnik jest zidentyfikowany na potrzeby podatku, z zastrzeżeniem pkt 24 lit. a ustawy. Pole opcjonalne dla przypadku określonego w art. 106e ust. 4 pkt 2 ustawy. W przypadku faktur wystawianych w procedurze uproszczonej przez drugiego w kolejności podatnika, o którym mowa w art. 135 ust. 1 pkt 4 lit. b i c oraz ust. 2 ustawy, numer, o którym mowa w art. 136 ust. 1 pkt 3 ustawy</remarks>
            [LxElementValue("P_4B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50", WhiteSpace = WhiteSpaceType.Replace)]
            public System.String P_4B ;

            /// <summary>A nullable <see cref="LiquidXmlObjects.Schemat.Tns.TKodyKrajowUEEnum" />, Optional : null when not set</summary>
            /// <remarks>Kod (prefiks) nabywcy VAT UE, o którym mowa w art. 106e ust. 1 pkt 24 ustawy oraz w przypadku, o którym mowa w art. 136 ust. 1 pkt 4 ustawy</remarks>
            [LxElementValue("P_5A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Replace)]
            public LiquidXmlObjects.Schemat.Tns.TKodyKrajowUEEnum? P_5A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Numer, za pomocą którego nabywca towarów lub usług jest identyfikowany dla podatku lub podatku od wartości dodanej, pod którym otrzymał on towary lub usługi, z zastrzeżeniem art. 106e ust. 1 pkt 24 lit. b ustawy. Pole opcjonalne dla przypadku określonego w art. 106e ust. 5 pkt 2 ustawy. W przypadku faktur wystawianych w procedurze uproszczonej przez drugiego w kolejności podatnika, o którym mowa w art. 135 ust. 1 pkt 4 lit. b i c oraz ust. 2 ustawy, numer, o którym mowa w art. 136 ust. 1 pkt 4 ustawy</remarks>
            [LxElementValue("P_5B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50", WhiteSpace = WhiteSpaceType.Replace)]
            public System.String P_5B ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            /// <remarks>Data dokonania lub zakończenia dostawy towarów lub wykonania usługi lub data otrzymania zapłaty, o której mowa w art. 106b ust. 1 pkt 4, o ile taka data jest określona i różni się od daty wystawienia faktury</remarks>
            [LxElementValue("P_6", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-01-01", MinInclusive = "2006-01-01")]
            public LiquidTechnologies.XmlObjects.LxDateTime? P_6 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto ze stawką podstawową - aktualnie 23% albo 22%. W przypadku faktur zaliczkowych, kwota zaliczki netto. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_1", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_1 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwota podatku od sumy wartości sprzedaży netto ze stawką podstawową - aktualnie 23% albo 22%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_1", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_1 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>W przypadku gdy faktura jest wystawiona w walucie obcej, kwota podatku od sumy wartości sprzedaży netto ze stawką podstawową, przeliczona zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy - aktualnie 23% albo 22%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_1W", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_1W ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto ze stawką obniżoną pierwszą - aktualnie 8 % albo 7%. W przypadku faktur zaliczkowych, kwota zaliczki netto. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_2", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_2 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwota podatku od sumy wartości sprzedaży netto ze stawką obniżoną pierwszą - aktualnie 8% albo 7%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_2", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_2 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>W przypadku gdy faktura jest wystawiona w walucie obcej, kwota podatku od sumy wartości sprzedaży netto ze stawką obniżoną, przeliczona zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy - aktualnie 8% albo 7%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_2W", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_2W ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto ze stawką obniżoną drugą - aktualnie 5%. W przypadku faktur zaliczkowych, kwota zaliczki netto. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_3", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_3 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwota podatku od sumy wartości sprzedaży netto ze stawką obniżoną drugą - aktualnie 5%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_3", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_3 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>W przypadku gdy faktura jest wystawiona w walucie obcej, kwota podatku od sumy wartości sprzedaży netto ze stawką obniżoną drugą, przeliczona zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy - aktualnie 5%. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_3W", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_3W ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto ze stawką obniżoną trzecią w walucie, w której faktura została wystawiona - procedura odwrotnego obciążenia, dla której podatnikiem jest nabywca zgodnie z art. 17 ust. 1 pkt 7 i 8 ustawy oraz dla stawki podatku w przypadku ryczałtu dla taksówek osobowych. W przypadku faktur zaliczkowych, kwota zaliczki netto. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_4", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_4 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwota "0" dla procedury odwrotnego obciążenia, dla której podatnikiem jest nabywca zgodnie z art. 17 ust. 1 pkt 7 i 8 ustawy oraz kwota podatku od sumy wartości sprzedaży netto dla stawki podatku w walucie, w której faktura została wystawiona w przypadku ryczałtu dla taksówek osobowych. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_4", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_4 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>W przypadku gdy faktura jest wystawiona w walucie obcej, kwota "0" dla procedury odwrotnego obciążenia, dla której podatnikiem jest nabywca zgodnie z art. 17 ust. 1 pkt 7 i 8 ustawy oraz kwota podatku od sumy wartości sprzedaży netto w walucie obcej dla stawki podatku w przypadku ryczałtu dla taksówek osobowych, przeliczona zgodnie z art. 31a w związku z art. 106e ust. 11 ustawy. W przypadku faktur zaliczkowych, kwota podatku wyliczona według wzoru, o którym mowa w art. 106f ust. 1 pkt 3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_14_4W", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_4W ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto dla transakcji dostawy towarów oraz świadczenia usług poza terytorium kraju. W przypadku faktur zaliczkowych, kwota zaliczki netto. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_5", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_5 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwota podatku od wartości dodanej w przypadku procedur szczególnych, o których mowa w dziale XII w rozdziałach 6a, 7 i 9 ustawy</remarks>
            [LxElementValue("P_14_5", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_14_5 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży netto ze stawką 0%. W przypadku faktur zaliczkowych, kwota zaliczki netto. Pole opcjonalne dla przypadków określonych w art. 106e ust. 2 i 3, a także ust. 4 pkt 3 i ust. 5 pkt 1-3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_6", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_6 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Suma wartości sprzedaży zwolnionej. W przypadku faktur zaliczkowych, kwota zaliczki netto. Pola opcjonalne dla przypadków określonych w art. 106e ust. 2 i 3, a także ust. 4 pkt 3 i ust. 5 pkt 1-3 ustawy. W przypadku faktur korygujących, kwota różnicy, o której mowa w art. 106j ust. 2 pkt 5 ustawy</remarks>
            [LxElementValue("P_13_7", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_13_7 ;

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            /// <remarks>Kwota należności ogółem. W przypadku faktur zaliczkowych kwota zapłaty dokumentowana fakturą. W przypadku faktur, o których mowa w art. 106f ust. 3 ustawy kwota pozostała do zapłaty. W przypadku faktur korygujących korekta kwoty wynikającej z faktury korygowanej. W przypadku, o którym mowa w art. 106j ust. 3 ustawy korekta kwot wynikających z faktur korygowanych</remarks>
            [LxElementValue("P_15", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal P_15 ;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku dostawy towarów lub świadczenia usług, w odniesieniu do których obowiązek podatkowy powstaje zgodnie z art. 19a ust. 5 pkt 1 lub art. 21 ust. 1 - wyrazy "metoda kasowa", należy podać wartość "true"; w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_16", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_16 ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku faktur, o których mowa w art. 106d ust. 1 - wyraz "samofakturowanie", należy podać wartość "true"; w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_17", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_17 ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku dostawy towarów lub wykonania usługi, dla których obowiązanym do rozliczenia podatku od wartości dodanej lub podatku o podobnym charakterze jest nabywca towaru lub usługi - wyrazy "odwrotne obciążenie", należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_18", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_18 ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>
            ///   W przypadku faktur, w których kwota należności ogółem przekracza kwotę<br/>
            ///   15 000 zł lub jej równowartość wyrażoną w walucie obcej, obejmujących<br/>
            ///   dokonaną na rzecz podatnika dostawę towarów lub świadczenie usług, o których mowa w załączniku nr 15 do ustawy - wyrazy "mechanizm<br/>
            ///   podzielonej płatności", przy czym do przeliczania na złote kwot wyrażonych w walucie obcej stosuje się zasady przeliczania kwot stosowane w celu określenia podstawy opodatkowania; należy podać wartość "true", w przeciwnym przypadku - wartość "false"
            /// </remarks>
            [LxElementValue("P_18A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_18A ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku dostawy towarów lub świadczenia usług zwolnionych od podatku na podstawie art. 43 ust. 1, art. 113 ust. 1 i 9 albo przepisów wydanych na podstawie art. 82 ust. 3 należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_19", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_19 ; = false;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_19 równa się "true" - należy wskazać przepis ustawy albo aktu wydanego na podstawie ustawy, na podstawie którego podatnik stosuje zwolnienie od podatku</remarks>
            [LxElementValue("P_19A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_19A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_19 równa się "true" - należy wskazać przepis dyrektywy 2006/112/WE, który zwalnia od podatku taką dostawę towarów lub takie świadczenie usług</remarks>
            [LxElementValue("P_19B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_19B ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_19 równa się "true" - należy wskazać inną podstawę prawną wskazującą na to, że dostawa towarów lub świadczenie usług korzysta ze zwolnienia</remarks>
            [LxElementValue("P_19C", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_19C ;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku, o którym mowa w art. 106c ustawy należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_20", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_20 ; = false;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Jeśli pole P_20 równa się "true" - należy podać nazwę organu egzekucyjnego lub imię i nazwisko komornika sądowego</remarks>
            [LxElementValue("P_20A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_20A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Jeśli pole P_20 równa się "true" - należy podać adres organu egzekucyjnego lub komornika sądowego</remarks>
            [LxElementValue("P_20B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_20B ;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku faktur wystawianych w imieniu i na rzecz podatnika przez jego przedstawiciela podatkowego należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_21", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_21 ; = false;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_21 równa się "true" - należy podać nazwę lub imię i nazwisko przedstawiciela podatkowego</remarks>
            [LxElementValue("P_21A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_21A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_21 równa się "true" - należy podać adres przedstawiciela podatkowego</remarks>
            [LxElementValue("P_21B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_21B ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeśli pole P_21 równa się "true" - należy podać numer przedstawiciela podatkowego, za pomocą którego jest on zidentyfikowany na potrzeby podatku</remarks>
            [LxElementValue("P_21C", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_21C ;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku gdy przedmiotem wewnątrzwspólnotowej dostawy są nowe środki transportu należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_22", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_22 ; = false;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
            /// <remarks>Jeśli pole P_22 równa się "true" - należy podać datę dopuszczenia nowego środka transportu do użytku</remarks>
            [LxElementValue("P_22A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))", MaxInclusive = "2030-12-31", MinInclusive = "1900-01-01")]
            public LiquidTechnologies.XmlObjects.LxDateTime? P_22A ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Jeśli pole P_22 równa się "true" a dostawa dotyczy pojazdów lądowych, o których mowa w art. 2 pkt 10 lit. a ustawy - należy podać przebieg pojazdu</remarks>
            [LxElementValue("P_22B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_22B ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Jeśli pole P_22 równa się "true" a dostawa dotyczy jednostek pływających, o których mowa w art. 2 pkt 10 lit. b ustawy, oraz statków powietrznych, o których mowa w art. 2 pkt 10 lit. c ustawy, należy podać liczbę godzin roboczych używania nowego środka transportu</remarks>
            [LxElementValue("P_22C", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_22C ;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku faktur wystawianych w procedurze uproszczonej przez drugiego w kolejności podatnika, o którym mowa w art. 135 ust. 1 pkt 4 lit. b i c oraz ust. 2, zawierającej adnotację, o której mowa w art. 136 ust. 1 pkt 1 i stwierdzenie, o którym mowa w art. 136 ust. 1 pkt 2 ustawy należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_23", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_23 ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku świadczenia usług turystyki, dla których podstawę opodatkowania stanowi zgodnie z art. 119 ust. 1 kwota marży, faktura - w zakresie danych określonych w ust. 1 pkt 1-17 - powinna zawierać wyłącznie dane określone w ust. 1 pkt 1-8 i 15-17, a także wyrazy "procedura marży dla biur podróży", należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_106E_2", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_106E_2 ; = false;

            /// <summary>A <see cref="System.Boolean" />, Required, Default : 'false'</summary>
            /// <remarks>W przypadku dostawy towarów używanych, dzieł sztuki, przedmiotów kolekcjonerskich i antyków, dla których podstawę opodatkowania stanowi zgodnie z art. 120 ust. 4 i 5 marża, należy podać wartość "true", w przeciwnym przypadku - wartość "false"</remarks>
            [LxElementValue("P_106E_3", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1, Default = "false")]
            public System.Boolean P_106E_3 ; = false;

            /// <summary>A <see cref="System.String" />, Optional : null when not set, Default : 'false'</summary>
            /// <remarks>Jeżeli pole P_106E_3 równa się "true", należy podać wyrazy: "procedura marży - towary używane" lub "procedura marży - dzieła sztuki" lub "procedura marży - przedmioty kolekcjonerskie i antyki"</remarks>
            [LxElementValue("P_106E_3A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256", Default = "false")]
            public System.String P_106E_3A ;

            /// <summary>A <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaElm.RodzajFakturyEnum" />, Required</summary>
            /// <remarks>Rodzaj faktury</remarks>
            [LxElementValue("RodzajFaktury", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1)]
            public LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaElm.RodzajFakturyEnum RodzajFaktury ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Przyczyna korekty dla faktur korygujących</remarks>
            [LxElementValue("PrzyczynaKorekty", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String PrzyczynaKorekty ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Numer faktury korygowanej</remarks>
            [LxElementValue("NrFaKorygowanej", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String NrFaKorygowanej ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Dla faktury korygującej - okres, do którego odnosi się udzielany opust lub obniżka, w przypadku gdy podatnik udziela opustu lub obniżki ceny w odniesieniu do wszystkich dostaw towarów lub usług dokonanych lub świadczonych na rzecz jednego odbiorcy w danym okresie</remarks>
            [LxElementValue("OkresFaKorygowanej", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String OkresFaKorygowanej ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Dla faktury, o której mowa w art. 106f ust. 3 i 4 ustawy - numery poprzednich faktur zaliczkowych</remarks>
            [LxElementValue("NrFaZaliczkowej", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String NrFaZaliczkowej ;

            /// <summary>An enumeration representing XSD simple type RodzajFaktury@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
            /// <remarks>Rodzaj faktury</remarks>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:Faktura/sequence/element:RodzajFaktury</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1655:8-1678:22</XsdLocation>
            public enum RodzajFakturyEnum
            {
                /// <summary>Represents the value 'VAT' in the XML</summary>
                [LxEnumValue("VAT")]
                VAT,
                /// <summary>Represents the value 'KOREKTA' in the XML</summary>
                [LxEnumValue("KOREKTA")]
                KOREKTA,
                /// <summary>Represents the value 'ZAL' in the XML</summary>
                [LxEnumValue("ZAL")]
                ZAL,
            }
        }

        /// <summary>Represent the inline xs:element FakturaCtrl@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Sumy kontrolne dla faktur</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:FakturaCtrl</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1704:5-1722:19</XsdLocation>
        [LxSimpleElementDefinition("FakturaCtrl", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class FakturaCtrlElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
            /// <remarks>Liczba faktur, w okresie którego dotyczy JPK_FA</remarks>
            [LxElementValue("LiczbaFaktur", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdNonNegativeInteger, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse, MinExclusive = "0", TotalDigits = "14")]
            public System.Numerics.BigInteger LiczbaFaktur ;

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            /// <remarks>Łączna wartość kolumny P_15 w tabeli Faktura w okresie, którego dotyczy JPK_FA</remarks>
            [LxElementValue("WartoscFaktur", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal WartoscFaktur ;

        }

        /// <summary>Represent the inline xs:element FakturaWiersz@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Szczegółowe pozycje faktury w walucie, w której wystawiono fakturę - węzeł opcjonalny dla faktury zaliczkowej, faktury korygującej fakturę zaliczkową, oraz faktur korygujących dotyczących wszystkich dostaw towarów lub usług dokonanych lub świadczonych w danym okresie, o których mowa w art. 106j ust. 3 ustawy, dla których należy podać dane dotyczące opustu lub obniżki w podziale na stawki podatku i procedury w sekcji Fa. W przypadku faktur korygujących, o których mowa w art. 106j ust. 3 ustawy, gdy opust lub obniżka ceny odnosi się do części dostaw towarów lub usług dokonanych lub świadczonych w danym okresie w sekcji FakturaWiersz należy podać nazwy (rodzaje) towarów lub usług objętych korektą. W przypadku faktur, o których mowa w art. 106f ust. 3 ustawy należy prezentować pełne wartości zamówienia lub umowy. W przypadku faktur korygujących pozycje faktury (w tym faktur korygujących faktury, o których mowa w art. 106f ust. 3 ustawy, jeśli korekta dotyczy wartości zamówienia) należy prezentować różnice wynikające z korekty poszczególnych pozycji lub storna poszczególnych pozycji korygowanych i prawidłowe wartości korygowanych pozycji jako osobne wiersze. W przypadku faktur korygujących faktury, o których mowa w art. 106f ust. 3 ustawy, jeśli korekta nie dotyczy wartości zamówienia i jednocześnie zmienia wysokość podstawy opodatkowania lub podatku, można wprowadzić zapis stornujący dany wiersz wg stanu przed korektą i zapis przywracający wartość zamówienia w celu potwierdzenia braku zmiany jego wartości</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:FakturaWiersz</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1723:5-1815:19</XsdLocation>
        [LxSimpleElementDefinition("FakturaWiersz", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class FakturaWierszElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            /// <remarks>Kolejny numer faktury, nadany w ramach jednej lub więcej serii, który w sposób jednoznaczny indentyfikuje fakturę</remarks>
            [LxElementValue("P_2B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_2B ; = "";

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Nazwa (rodzaj) towaru lub usługi. Pole opcjonalne wyłącznie dla przypadku określonego w art 106j ust. 3 pkt 2 ustawy (faktura korekta)</remarks>
            [LxElementValue("P_7", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_7 ;

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            /// <remarks>Miara dostarczonych towarów lub zakres wykonanych usług. Pole opcjonalne dla przypadku określonego w art. 106e ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_8A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_8A ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Ilość (liczba) dostarczonych towarów lub zakres wykonanych usług. Pole opcjonalne dla przypadku określonego w art. 106e ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_8B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "22", FractionDigits = "6")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_8B ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Cena jednostkowa towaru lub usługi bez kwoty podatku (cena jednostkowa netto). Pole opcjonalne dla przypadków określonych w art. 106e ust. 2 i 3 oraz ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_9A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_9A ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Cena wraz z kwotą podatku (cena jednostkowa brutto), w przypadku zastosowania art. 106e ust. 7 i 8 ustawy</remarks>
            [LxElementValue("P_9B", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_9B ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Kwoty wszelkich opustów lub obniżek cen, w tym w formie rabatu z tytułu wcześniejszej zapłaty, o ile nie zostały one uwzględnione w cenie jednostkowej netto. Pole opcjonalne dla przypadków określonych w art. 106e ust. 2 i 3 oraz ust. 5 pkt 1 ustawy</remarks>
            [LxElementValue("P_10", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_10 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Wartość dostarczonych towarów lub wykonanych usług, objętych transakcją, bez kwoty podatku (wartość sprzedaży netto). Pole opcjonalne dla przypadków określonych w art. 106e ust. 2 i 3 oraz ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_11", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_11 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Wartość sprzedaży brutto, w przypadku zastosowania art. 106e ust. 7 i 8 ustawy</remarks>
            [LxElementValue("P_11A", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_11A ;

            /// <summary>A nullable <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszElm.P_12Enum" />, Optional : null when not set</summary>
            /// <remarks>Stawka podatku. Pole opcjonalne dla przypadków określonych w art. 106e ust. 2, 3, 4 pkt 3 i ust. 5 pkt 3 ustawy</remarks>
            [LxElementValue("P_12", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1)]
            public LiquidXmlObjects.Schemat.Tns.JPKElm.FakturaWierszElm.P_12Enum? P_12 ;

            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
            /// <remarks>Stawka podatku od wartości dodanej w przypadku procedur szczególnych, o których mowa w dziale XII w rozdziałach 6a, 7 i 9 ustawy VAT</remarks>
            [LxElementValue("P_12_XII", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "100", MinInclusive = "0", TotalDigits = "9", FractionDigits = "6")]
            public LiquidTechnologies.XmlObjects.BigDecimal? P_12_XII ;

            /// <summary>An enumeration representing XSD simple type P_12@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
            /// <remarks>Stawka podatku. Pole opcjonalne dla przypadków określonych w art. 106e ust. 2, 3, 4 pkt 3 i ust. 5 pkt 3 ustawy</remarks>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:FakturaWiersz/sequence/element:P_12</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1774:8-1807:22</XsdLocation>
            public enum P_12Enum
            {
                /// <summary>Represents the value '23' in the XML</summary>
                [LxEnumValue("23")]
                N23,
                /// <summary>Represents the value '22' in the XML</summary>
                [LxEnumValue("22")]
                N22,
                /// <summary>Represents the value '8' in the XML</summary>
                [LxEnumValue("8")]
                N8,
                /// <summary>Represents the value '7' in the XML</summary>
                [LxEnumValue("7")]
                N7,
                /// <summary>Represents the value '5' in the XML</summary>
                [LxEnumValue("5")]
                N5,
                /// <summary>Represents the value '4' in the XML</summary>
                [LxEnumValue("4")]
                N4,
                /// <summary>Represents the value '3' in the XML</summary>
                [LxEnumValue("3")]
                N3,
                /// <summary>Represents the value '0' in the XML</summary>
                [LxEnumValue("0")]
                N0,
                /// <summary>Represents the value 'zw' in the XML</summary>
                [LxEnumValue("zw")]
                Zw,
                /// <summary>Represents the value 'oo' in the XML</summary>
                [LxEnumValue("oo")]
                Oo,
                /// <summary>Represents the value 'np' in the XML</summary>
                [LxEnumValue("np")]
                Np,
            }
        }

        /// <summary>Represent the inline xs:element FakturaWierszCtrl@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Sumy kontrolne dla wierszy faktur</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/element:FakturaWierszCtrl</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1816:5-1834:19</XsdLocation>
        [LxSimpleElementDefinition("FakturaWierszCtrl", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class FakturaWierszCtrlElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
            /// <remarks>Liczba wierszy faktur, w okresie którego dotyczy JPK_FA</remarks>
            [LxElementValue("LiczbaWierszyFaktur", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdNonNegativeInteger, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse, MinExclusive = "0", TotalDigits = "14")]
            public System.Numerics.BigInteger LiczbaWierszyFaktur ;

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            /// <remarks>Łączna wartość kolumny P_11 tabeli FakturaWiersz w okresie, którego dotyczy JPK_FA</remarks>
            [LxElementValue("WartoscWierszyFaktur", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal WartoscWierszyFaktur ;

        }

        /// <summary>Represent the inline xs:element Zamowienie@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Zamówienie lub umowa, o których mowa w art. 106f ust. 1 pkt 4 ustawy (dla faktur zaliczkowych) w walucie, w której wystawiono fakturę zaliczkową. W przypadku faktury korygującej fakturę zaliczkową należy prezentować różnice wynikające z korekty poszczególnych pozycji zamówienia lub umowy lub storna poszczególnych korygowanych pozycji zamówienia lub umowy i prawidłowe wartości korygowanych pozycji jako osobne wiersze jeśli korekta dotyczy wartości zamówienia. W przypadku faktur korygujących faktury zaliczkowe, jeśli korekta nie dotyczy wartości zamówienia i jednocześnie zmienia wysokość podstawy opodatkowania lub podatku, można wprowadzić zapis stornujący dany wiersz wg stanu przed korektą i zapis przywracający wartość zamówienia w celu potwierdzenia braku zmiany jego wartości</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/sequence/element:Zamowienie</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1836:6-1934:20</XsdLocation>
        [LxSimpleElementDefinition("Zamowienie", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class ZamowienieElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
            /// <remarks>Numer faktury, z którym związane jest zamówienie lub umowa, identyczny jak w polu P_2A</remarks>
            [LxElementValue("P_2AZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
            public System.String P_2AZ ; = "";

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            /// <remarks>Wartość zamówienia lub umowy z uwzględnieniem kwoty podatku</remarks>
            [LxElementValue("WartoscZamowienia", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal WartoscZamowienia ;

            /// <summary>A collection of <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm.ZamowienieWierszElm" /></summary>
            /// <remarks>Szczegółowe pozycje zamówienia lub umowy w walucie, w której wystawiono fakturę zaliczkową</remarks>
            [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
            public List<LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm.ZamowienieWierszElm> ZamowienieWiersz { get; } = new List<LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm.ZamowienieWierszElm>();

            /// <summary>Represent the inline xs:element ZamowienieWiersz@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
            /// <remarks>Szczegółowe pozycje zamówienia lub umowy w walucie, w której wystawiono fakturę zaliczkową</remarks>
            /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/sequence/element:Zamowienie/sequence/sequence/element:ZamowienieWiersz</XsdPath>
            /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
            /// <XsdLocation>1853:10-1930:24</XsdLocation>
            [LxSimpleElementDefinition("ZamowienieWiersz", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
            public partial class ZamowienieWierszElm : LiquidXmlObjects.Schemat.LxBase
            {
                /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
                /// <remarks>Nazwa (rodzaj) towaru lub usługi</remarks>
                [LxElementValue("P_7Z", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
                public System.String P_7Z ;

                /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
                /// <remarks>Miara zamówionego towaru lub zakres usługi</remarks>
                [LxElementValue("P_8AZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "256")]
                public System.String P_8AZ ;

                /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                /// <remarks>Ilość zamówionego towaru lub zakres usługi</remarks>
                [LxElementValue("P_8BZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "22", FractionDigits = "6")]
                public LiquidTechnologies.XmlObjects.BigDecimal? P_8BZ ;

                /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                /// <remarks>Cena jednostkowa netto</remarks>
                [LxElementValue("P_9AZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
                public LiquidTechnologies.XmlObjects.BigDecimal? P_9AZ ;

                /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                /// <remarks>Wartość zamówionego towaru lub usługi bez kwoty podatku</remarks>
                [LxElementValue("P_11NettoZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
                public LiquidTechnologies.XmlObjects.BigDecimal? P_11NettoZ ;

                /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                /// <remarks>Kwota podatku od zamówionego towaru lub usługi</remarks>
                [LxElementValue("P_11VatZ", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
                public LiquidTechnologies.XmlObjects.BigDecimal? P_11VatZ ;

                /// <summary>A nullable <see cref="LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm.ZamowienieWierszElm.P_12ZEnum" />, Optional : null when not set</summary>
                /// <remarks>Stawka podatku</remarks>
                [LxElementValue("P_12Z", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1)]
                public LiquidXmlObjects.Schemat.Tns.JPKElm.ZamowienieElm.ZamowienieWierszElm.P_12ZEnum? P_12Z ;

                /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                /// <remarks>Stawka podatku od wartości dodanej w przypadku procedur szczególnych, o których mowa w dziale XII w rozdziałach 6a, 7 i 9 ustawy VAT</remarks>
                [LxElementValue("P_12Z_XII", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "100", MinInclusive = "0", TotalDigits = "9", FractionDigits = "6")]
                public LiquidTechnologies.XmlObjects.BigDecimal? P_12Z_XII ;

                /// <summary>An enumeration representing XSD simple type P_12Z@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/</summary>
                /// <remarks>Stawka podatku</remarks>
                /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/sequence/element:Zamowienie/sequence/sequence/element:ZamowienieWiersz/sequence/element:P_12Z</XsdPath>
                /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
                /// <XsdLocation>1889:13-1922:27</XsdLocation>
                public enum P_12ZEnum
                {
                    /// <summary>Represents the value '23' in the XML</summary>
                    [LxEnumValue("23")]
                    N23,
                    /// <summary>Represents the value '22' in the XML</summary>
                    [LxEnumValue("22")]
                    N22,
                    /// <summary>Represents the value '8' in the XML</summary>
                    [LxEnumValue("8")]
                    N8,
                    /// <summary>Represents the value '7' in the XML</summary>
                    [LxEnumValue("7")]
                    N7,
                    /// <summary>Represents the value '5' in the XML</summary>
                    [LxEnumValue("5")]
                    N5,
                    /// <summary>Represents the value '4' in the XML</summary>
                    [LxEnumValue("4")]
                    N4,
                    /// <summary>Represents the value '3' in the XML</summary>
                    [LxEnumValue("3")]
                    N3,
                    /// <summary>Represents the value '0' in the XML</summary>
                    [LxEnumValue("0")]
                    N0,
                    /// <summary>Represents the value 'zw' in the XML</summary>
                    [LxEnumValue("zw")]
                    Zw,
                    /// <summary>Represents the value 'oo' in the XML</summary>
                    [LxEnumValue("oo")]
                    Oo,
                    /// <summary>Represents the value 'np' in the XML</summary>
                    [LxEnumValue("np")]
                    Np,
                }
            }

        }

        /// <summary>Represent the inline xs:element ZamowienieCtrl@http://jpk.mf.gov.pl/wzor/2022/02/17/02171/.</summary>
        /// <remarks>Sumy kontrolne dla zamówień lub umów</remarks>
        /// <XsdPath>schema:Schemat_JPK_FA(4)_v1-0.xsd/element:JPK/sequence/sequence/element:ZamowienieCtrl</XsdPath>
        /// <XsdFile>C:\Users\lukas\Downloads\Schemat_JPK_FA(4)_v1-0.xsd</XsdFile>
        /// <XsdLocation>1935:6-1953:20</XsdLocation>
        [LxSimpleElementDefinition("ZamowienieCtrl", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", ElementScopeType.InlineElement)]
        public partial class ZamowienieCtrlElm : LiquidXmlObjects.Schemat.LxBase
        {
            /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
            /// <remarks>Liczba zamówień lub umów, w okresie którego dotyczy JPK_FA</remarks>
            [LxElementValue("LiczbaZamowien", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdNonNegativeInteger, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse, MinExclusive = "0", TotalDigits = "14")]
            public System.Numerics.BigInteger LiczbaZamowien ;

            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
            /// <remarks>Łączna wartość kolumny WartoscZamowienia w Tabeli Zamowienie w okresie, którego dotyczy JPK_FA</remarks>
            [LxElementValue("WartoscZamowien", "http://jpk.mf.gov.pl/wzor/2022/02/17/02171/", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "18", FractionDigits = "2")]
            public LiquidTechnologies.XmlObjects.BigDecimal WartoscZamowien ;

        }

    }

    #endregion

}

namespace LiquidXmlObjects.Schemat.Ns
{
    #region Unions
    /// <summary>A union representing the XSD simple type TNrREGON@http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/</summary>
    /// <remarks>Numer REGON</remarks>
    /// <XsdPath>schema:ElementarneTypyDanych_v...xsd/simpleType:TNrREGON</XsdPath>
    /// <XsdFile>http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2018/08/24/eD/DefinicjeTypy/ElementarneTypyDanych_v5-0E.xsd</XsdFile>
    /// <XsdLocation>169:2-185:19</XsdLocation>
    public partial class TNrREGONUnion : Union<System.String>
    {
        /// <summary>Constructor : create a union from a <see cref="System.String" /></summary>
        [LxUnion(LxValueType.Value, XsdType.XsdString, Pattern = "\\d{9}")]
        [LxUnion(LxValueType.Value, XsdType.XsdString, Pattern = "\\d{14}")]
        public TNrREGONUnion(System.String value)  : base(value) { }

    }

    #endregion

}

namespace LiquidXmlObjects.Schemat.Xsd
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

