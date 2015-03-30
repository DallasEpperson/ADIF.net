using System.Collections.Generic;
using System.Xml.Serialization;

namespace ADIF
{
    [XmlRoot("ADX")]
    public class ADIFData
    {
        [XmlElement("HEADER")]
        public ADIFHeader Header;

        [XmlArray("RECORDS")]
        [XmlArrayItem("RECORD")]
        public List<ADIFRecord> Records;
    }


    public class ADIFHeader
    {
        [XmlElement("ADIF_VER")]
        public string ADIFVersion;

        [XmlElement("CREATED_TIMESTAMP")]
        public string CreatedTimestamp;

        [XmlElement("PROGRAMID")]
        public string ProgramID;

        [XmlElement("PROGRAMVERSION")]
        public string ProgramVersion;

        [XmlElement("USERDEF")]
        public List<ADIFUserDefinedFieldHeader> UserDefinedFields;
    }

    public class ADIFRecord
    {
        /// <summary>
        /// The contacted station's complete mailing address: full name, street address, city, postal code, and country
        /// </summary>
        [XmlElement("ADDRESS")]
        public string Address;

        [XmlElement("ADDRESS_INTL")]
        public string AddressInternational;

        [XmlElement("AGE")]
        public float Age;

        [XmlElement("A_INDEX")]
        public float AIndex;

        [XmlElement("ANT_AZ")]
        public float AntennaAzimuth;

        [XmlElement("ANT_EL")]
        public float AntennaElevation;

        [XmlElement("ANT_PATH")]
        public string AntennaPath;

        [XmlElement("ARRL_SECT")]
        public string ARRLSection;

        [XmlElement("AWARD_SUBMITTED")]
        public string AwardSubmitted; // CSV of SPONSOR_PROGRAM_AWARD where sponsor is validated

        [XmlElement("AWARD_GRANTED")]
        public string AwardGranted;

        [XmlElement("BAND")]
        public string Band;

        [XmlElement("BAND_RX")]
        public string BandReceived;

        [XmlElement("CALL")]
        public string Callsign;

        [XmlElement("CHECK")]
        public string Check;

        [XmlElement("CLASS")]
        public string Class;

        [XmlElement("CLUBLOG_QSO_UPLOAD_DATE")]
        public string ClubLogQSOUploadDate;

        [XmlElement("CLUBLOG_QSO_UPLOAD_STATUS")]
        public string ClubLogQSOUploadStatus;

        [XmlElement("CNTY")]
        public string County;

        [XmlElement("COMMENT")]
        public string Comment;

        [XmlElement("COMMENT_INTL")]
        public string CommentInternational;

        [XmlElement("CONT")]
        public string Continent;

        [XmlElement("CONTACTED_OP")]
        public string ContactedOperatorCallsign;

        [XmlElement("CONTEST_ID")]
        public string ContestID;

        [XmlElement("COUNTRY")]
        public string Country;

        [XmlElement("COUNTRY_INTL")]
        public string CountryInternational;

        [XmlElement("CQZ")]
        public string CQZone;

        [XmlElement("CREDIT_SUBMITTED")]
        public string CreditSubmitted; // CSV like IOTA,WAS:LOTW&CARD,DXCC:CARD

        [XmlElement("CREDIT_GRANTED")]
        public string CreditGranted; // same as above

        [XmlElement("DISTANCE")]
        public float Distance; // in KM

        [XmlElement("DXCC")]
        public int DXCC; // Country code

        [XmlElement("EMAIL")]
        public string EmailAddress;

        [XmlElement("EQ_CALL")]
        public string CallsignContactedOwner;

        [XmlElement("EQSL_QSLRDATE")]
        public string EQSLReceivedDate;

        [XmlElement("EQSL_QSLSDATE")]
        public string EQSLSentDate;

        [XmlElement("EQSL_QSL_RCVD")]
        public string EQSLReceivedStatus;

        [XmlElement("EQSL_QSL_SENT")]
        public string EQSLSentStatus; // todo validate me

        [XmlElement("FISTS")]
        public string FISTS_CW_Club;

        [XmlElement("FISTS_CC")]
        public string FISTS_CW_CenturyCertificate;

        [XmlElement("FORCE_INIT")]
        public bool? ForceInit; // ?

        [XmlElement("FREQ")]
        public float Frequency; // Mhz

        [XmlElement("FREQ_RX")]
        public float FrequencyReceived; // Mhz

        [XmlElement("GRIDSQUARE")]
        public string Gridsquare; // todo validate me

        [XmlElement("HRDLOG_QSO_UPLOAD_DATE")]
        public string HRDLogQSOUploadDate;

        [XmlElement("HRDLOG_QSO_UPLOAD_STATUS")]
        public string HRDLogQSOUploadStatus;

        [XmlElement("IOTA")]
        public string IOTADesignator;

        [XmlElement("IOTA_ISLAND_ID")]
        public string IOTAIslandID;

        [XmlElement("ITUZ")]
        public int ITUZone;

        [XmlElement("K_INDEX")]
        public int KIndex;

        [XmlElement("LAT")]
        public string Latitude; // XDDD MM.MMM

        [XmlElement("LON")]
        public string Longitude; // same above

        [XmlElement("LOTW_QSLRDATE")]
        public string LOTW_QSLReceivedDate;

        [XmlElement("LOTW_QSLSDATE")]
        public string LOTW_QSLSentDate;

        [XmlElement("LOTW_QSL_RCVD")]
        public string LOTW_QSLReceived;

        [XmlElement("LOTW_QSL_SENT")]
        public string LOTW_QSLSent;

        [XmlElement("MAX_BURSTS")]
        public float MaxBursts;

        [XmlElement("MODE")]
        public string Mode;

        [XmlElement("MS_SHOWER")]
        public string MeteorShowerName;

        [XmlElement("MY_CITY")]
        public string MyCity;

        [XmlElement("MY_CITY_INTL")]
        public string MyCityInternational;

        [XmlElement("MY_CNTY")]
        public string MyCounty;

        [XmlElement("MY_COUNTRY")]
        public string MyCountry;

        [XmlElement("MY_COUNTRY_INTL")]
        public string MyCountryInternational;

        [XmlElement("MY_CQ_ZONE")]
        public string MyCQZone;

        [XmlElement("MY_DXCC")]
        public string MyCountryCode;

        [XmlElement("MY_FISTS")]
        public string MyFISTS;

        [XmlElement("MY_GRIDSQUARE")]
        public string MyGridsquare;

        [XmlElement("MY_IOTA")]
        public string MyIOTADesignator;

        [XmlElement("MY_IOTA_ISLAND_ID")]
        public string MyIOTAIslandIdentifier;

        [XmlElement("MY_ITU_ZONE")]
        public int MyITUZone;

        [XmlElement("MY_LAT")]
        public string MyLatitude;

        [XmlElement("MY_LON")]
        public string MyLongitude;

        [XmlElement("MY_NAME")]
        public string MyName;

        [XmlElement("MY_NAME_INTL")]
        public string MyNameInternational;

        [XmlElement("MY_POSTAL_CODE")]
        public string MyPostalCode;

        [XmlElement("MY_POSTAL_CODE_INTL")]
        public string MyPostalCodeInternational;

        [XmlElement("MY_RIG")]
        public string MyRig;

        [XmlElement("MY_RIG_INTL")]
        public string MyRigInternational;

        [XmlElement("MY_SIG")]
        public string MySpecialInterest;

        [XmlElement("MY_SIG_INTL")]
        public string MySpecialInterestInternational;

        [XmlElement("MY_SIG_INFO")]
        public string MySpecialInterestInfo;

        [XmlElement("MY_SIG_INFO_INTL")]
        public string MySpecialInterestInfoInternational;

        [XmlElement("MY_SOTA_REF")]
        public string MySOTAReference; // eg W2/WE-003 or G/LD-003

        [XmlElement("MY_STATE")]
        public string MyState;

        [XmlElement("MY_STREET")]
        public string MyStreet;

        [XmlElement("MY_STREET_INTL")]
        public string MyStreetInternational;

        [XmlElement("MY_USACA_COUNTIES")]
        public string MyUSACACounties; // MA,Franklin:MA,Hampshire

        [XmlElement("MY_VUCC_GRIDS")]
        public string MyVUCCGrids; // EN98,FM08,EM97,FM07

        [XmlElement("NAME")]
        public string Name;

        [XmlElement("NAME_INTL")]
        public string NameInternational;

        [XmlElement("NOTES")]
        public string Notes;

        [XmlElement("NOTES_INTL")]
        public string NotesInternational;

        [XmlElement("NR_BURSTS")]
        public float MeteorScatterBursts;

        [XmlElement("NR_PINGS")]
        public float MeteorScatterPings;

        [XmlElement("OPERATOR")]
        public string OperatorCallsign;

        [XmlElement("OWNER_CALLSIGN")]
        public string OwnerCallsign;

        [XmlElement("PFX")]
        public string ContactedWPXPrefix;

        [XmlElement("PRECEDENCE")]
        public string Precedence;

        [XmlElement("PROP_MODE")]
        public string PropagationMode;

        [XmlElement("PUBLIC_KEY")]
        public string PublicEncryptionKey;

        [XmlElement("QRZCOM_QSO_UPLOAD_DATE")]
        public string QRZCOM_QSO_UploadDate;

        [XmlElement("QRZCOM_QSO_UPLOAD_STATUS")]
        public string QRZCOM_QSO_UploadStatus;

        [XmlElement("QSLMSG")]
        public string QSLCardMessage;

        [XmlElement("QSLMSG_INTL")]
        public string QSLCardMessageInternational;

        [XmlElement("QSLRDATE")]
        public string QSLReceivedDate;

        [XmlElement("QSLSDATE")]
        public string QSLSentDate;

        [XmlElement("QSL_RCVD")]
        public string QSLReceivedStatus;

        [XmlElement("QSL_RCVD_VIA")]
        public string QSLReceivedVia;

        [XmlElement("QSL_SENT")]
        public string QSLSentStatus;

        [XmlElement("QSL_SENT_VIA")]
        public string QSLSentVia;

        [XmlElement("QSL_VIA")]
        public string QSLVia;

        [XmlElement("QSO_COMPLETE")]
        public string QSOComplete;

        [XmlElement("QSO_DATE")]
        public string QSODate; // yyyymmdd

        [XmlElement("QSO_DATE_OFF")]
        public string QSODateOff;

        [XmlElement("QSO_RANDOM")]
        public bool? QSORandom;

        [XmlElement("QTH")]
        public string QTH;

        [XmlElement("QTH_INTL")]
        public string QTHInternational;

        [XmlElement("RIG")]
        public string Rig;

        [XmlElement("RIG_INTL")]
        public string RigInternational;

        [XmlElement("RST_RCVD")]
        public string RSTReceived;

        [XmlElement("RST_SENT")]
        public string RSTSent;

        [XmlElement("RX_PWR")]
        public float ContactedTransmitterPower; // Watts

        [XmlElement("SAT_MODE")]
        public string SatelliteMode;

        [XmlElement("SAT_NAME")]
        public string SatelliteName;

        [XmlElement("SFI")]
        public float SolarFlux;

        [XmlElement("SIG")]
        public string ContactedSpecialInterest;

        [XmlElement("SIG_INTL")]
        public string ContactedSpecialInterestInternational;

        [XmlElement("SIG_INFO")]
        public string ContactedSpecialInterestInfo;

        [XmlElement("SIG_INFO_INTL")]
        public string ContactedSpecialInterestInfoInternational;

        [XmlElement("SKCC")]
        public string ContactedSKCC;

        [XmlElement("SOTA_REF")]
        public string ContactedSOTAReference;

        [XmlElement("SRX")]
        public int QSOReceivedSerialNumber;

        [XmlElement("SRX_STRING")]
        public string QSOReceivedInformation;

        [XmlElement("STATE")]
        public string ContactedState;

        [XmlElement("STATION_CALLSIGN")]
        public string StationCallsign;

        [XmlElement("STX")]
        public int QSOTransmittedSerialNumber;

        [XmlElement("STX_STRING")]
        public string QSOTransmittedInformation;

        [XmlElement("SUBMODE")]
        public string Submode;

        [XmlElement("SWL")]
        public bool? SWL;

        [XmlElement("TEN_TEN")]
        public int TenTen;

        [XmlElement("TIME_OFF")]
        public string TimeOff; // HHMM or HHMMSS in UTC

        [XmlElement("TIME_ON")]
        public string TimeOn; // same

        [XmlElement("TX_PWR")]
        public float TransmitPower; // Watts

        [XmlElement("USACA_COUNTIES")]
        public string USACACounties; // MA,Franklin:MA,Hampshire

        [XmlElement("VUCC_GRIDS")]
        public string VUCCGrids;

        [XmlElement("WEB")]
        public string ContactedURL;

        [XmlElement("USERDEF")]
        public List<ADIFUserDefinedFieldRecord> UserDefinedFields;

        [XmlElement("APP")]
        public List<ADIFAppDefinedFieldRecord> AppDefinedFields;

        public bool ShouldSerializeAge() { return Age != 0; }
        public bool ShouldSerializeAIndex() { return AIndex != 0; }
        public bool ShouldSerializeAntennaAzimuth() { return AntennaAzimuth != 0; }
        public bool ShouldSerializeAntennaElevation() { return AntennaElevation != 0; }
        public bool ShouldSerializeDistance() { return Distance != 0; }
        public bool ShouldSerializeDXCC() { return DXCC != 0; }
        public bool ShouldSerializeForceInit() { return ForceInit.HasValue; }
        public bool ShouldSerializeFrequency() { return Frequency != 0; }
        public bool ShouldSerializeFrequencyReceived() { return FrequencyReceived != 0; }
        public bool ShouldSerializeITUZone() { return ITUZone != 0; }
        public bool ShouldSerializeKIndex() { return KIndex != 0; }
        public bool ShouldSerializeMaxBursts() { return MaxBursts != 0; }
        public bool ShouldSerializeMyITUZone() { return MyITUZone != 0; }
        public bool ShouldSerializeMeteorScatterBursts() { return MeteorScatterBursts != 0; }
        public bool ShouldSerializeMeteorScatterPings() { return MeteorScatterPings != 0; }
        public bool ShouldSerializeQSORandom() { return QSORandom.HasValue; }
        public bool ShouldSerializeContactedTransmitterPower() { return ContactedTransmitterPower != 0; }
        public bool ShouldSerializeSolarFlux() { return SolarFlux != 0; }
        public bool ShouldSerializeQSOReceivedSerialNumber() { return QSOReceivedSerialNumber != 0; }
        public bool ShouldSerializeQSOTransmittedSerialNumber() { return QSOTransmittedSerialNumber != 0; }
        public bool ShouldSerializeSWL() { return SWL.HasValue; }
        public bool ShouldSerializeTenTen() { return TenTen != 0; }
        public bool ShouldSerializeTransmitPower() { return TransmitPower != 0; }
    }

    public class ADIFUserDefinedFieldHeader
    {
        [XmlAttribute("FIELDID")]
        public int FieldID;
        [XmlAttribute("TYPE")]
        public string Type;
        [XmlAttribute("ENUM")]
        public string Enum;
        [XmlAttribute("RANGE")]
        public string Range;
        [XmlText]
        public string Value;
    }

    public class ADIFUserDefinedFieldRecord
    {
        [XmlAttribute("FIELDNAME")]
        public string FieldName;
        [XmlText]
        public string Value;

        public ADIFUserDefinedFieldRecord() { }

        public ADIFUserDefinedFieldRecord(string Name, string Val)
        {
            FieldName = Name;
            Value = Val;
        }
    }

    public class ADIFAppDefinedFieldRecord
    {
        [XmlAttribute("PROGRAMID")]
        public string ProgramID;
        [XmlAttribute("FIELDNAME")]
        public string FieldName;
        [XmlAttribute("TYPE")]
        public string DataType;
        [XmlText]
        public string Data;

        public ADIFAppDefinedFieldRecord() { }

        public ADIFAppDefinedFieldRecord(string progID, string fieldName, string dataType, string data)
        {
            ProgramID = progID;
            FieldName = fieldName;
            DataType = dataType;
            Data = data;
        }
    }

    public class ADIFElementAttribute : XmlElementAttribute
    {
        public ADIFElementAttribute(string elementName) : base(elementName)
        {
        }
    }
}
