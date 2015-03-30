using ADIF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ADIFIOTest
{
    [TestClass]
    public class XMLSerialization
    {
        [TestMethod]
        public void CanSerializeHeaderAndNoRecords()
        {
            var dataObject = new ADIFData();
            dataObject.Header = new ADIFHeader
            {
                ADIFVersion = ADIFIO.ADIFVersion,
                CreatedTimestamp = "20150118 234500",
                ProgramID = "Test Program",
                ProgramVersion = "0.1 alpha"
            };
            dataObject.Records = new List<ADIFRecord>();

            var adx = ADIFIO.ConvertToADX(dataObject);

            var rgx = new Regex(@"<\?xml.+\?>\s*<ADX>\s*<HEADER>[\s\S]*<\/HEADER>\s*<RECORDS \/>\s*<\/ADX>");
            Assert.IsTrue(rgx.IsMatch(adx));
        }

        [TestMethod]
        public void CanSerializeSampleFile()
        {
            // serialize sample ADX file from http://www.adif.org/304/ADIF_304.htm#ADX_File_Format 
            var dataObject = new ADIFData();
            dataObject.Header = new ADIFHeader();
            dataObject.Header.ADIFVersion = ADIFIO.ADIFVersion;
            dataObject.Header.ProgramID = "monolog";
            dataObject.Header.UserDefinedFields = new List<ADIFUserDefinedFieldHeader>();
            dataObject.Header.UserDefinedFields.Add(new ADIFUserDefinedFieldHeader { FieldID = 1, Type = "N", Value = "EPC" });
            dataObject.Header.UserDefinedFields.Add(new ADIFUserDefinedFieldHeader { FieldID = 2, Type = "E", Enum = "{S,M,L}", Value = "SWEATERSIZE" });
            dataObject.Header.UserDefinedFields.Add(new ADIFUserDefinedFieldHeader { FieldID = 3, Type = "E", Range = "{5:20}", Value = "SHOESIZE" });

            dataObject.Records = new List<ADIFRecord>();

            var firstRecord = new ADIFRecord();
            firstRecord.QSODate = "19900620";
            firstRecord.TimeOn = "1523";
            firstRecord.Callsign = "VK9NS";
            firstRecord.Band = "20M";
            firstRecord.Mode = "RTTY";

            firstRecord.UserDefinedFields = new List<ADIFUserDefinedFieldRecord>();
            firstRecord.UserDefinedFields.Add(new ADIFUserDefinedFieldRecord("SWEATERSIZE", "M"));
            firstRecord.UserDefinedFields.Add(new ADIFUserDefinedFieldRecord("SHOESIZE", "11"));

            firstRecord.AppDefinedFields = new List<ADIFAppDefinedFieldRecord>();
            firstRecord.AppDefinedFields.Add(new ADIFAppDefinedFieldRecord("MONOLOG", "Compression", "s", "off"));

            var secondRecord = new ADIFRecord();
            secondRecord.QSODate = "20101022";
            secondRecord.TimeOn = "0111";
            secondRecord.Callsign = "ON4UN";
            secondRecord.Band = "40M";
            secondRecord.Mode = "PSK";
            secondRecord.Submode = "PSK63";

            secondRecord.UserDefinedFields = new List<ADIFUserDefinedFieldRecord>();
            secondRecord.UserDefinedFields.Add(new ADIFUserDefinedFieldRecord("EPC", "32123"));

            secondRecord.AppDefinedFields = new List<ADIFAppDefinedFieldRecord>();
            secondRecord.AppDefinedFields.Add(new ADIFAppDefinedFieldRecord("MONOLOG", "COMPRESSION", "s", "off"));

            dataObject.Records.Add(firstRecord);
            dataObject.Records.Add(secondRecord);

            var adx = ADIFIO.ConvertToADX(dataObject);
            ADIFIO.SaveADX(dataObject, "C:\\data.xml");
        }
    }
}
