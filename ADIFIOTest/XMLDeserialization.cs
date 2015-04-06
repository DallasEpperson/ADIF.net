using ADIF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ADIFIOTest
{
    [TestClass]
    public class XMLDeserialization
    {
        [TestMethod]
        public void CanDeserializeSampleADX()
        {
            var adxData = GetResource("sample.adx");

            var data = ADIFIO.ConvertFromADX(adxData);

            Assert.IsTrue(data.Header.ADIFVersion == "3.0.4");
            Assert.IsTrue(data.Header.ProgramID == "monolog");
            Assert.IsTrue(data.Header.UserDefinedFields.Count == 3);
            Assert.IsTrue(data.Header.UserDefinedFields.Any(f => 
                f.FieldID == 1 && 
                f.Type == "N" && 
                f.Value == "EPC"));

            Assert.IsTrue(data.Records.Count == 2);
            Assert.IsTrue(data.Records.Any(r =>
                r.QSODate == "19900620" &&
                r.TimeOn == "1523" &&
                r.Callsign == "VK9NS" &&
                r.Band == "20M" &&
                r.Mode == "RTTY" &&
                r.UserDefinedFields.Count == 2 &&
                r.UserDefinedFields.Any(u => 
                    u.FieldName == "SWEATERSIZE" && 
                    u.Value == "M") &&
                r.AppDefinedFields.Count == 1 &&
                r.AppDefinedFields.Any(a => 
                    a.ProgramID == "MONOLOG" && 
                    a.FieldName == "Compression" && 
                    a.DataType == "s" && 
                    a.Data == "off")));
        }

        private string GetResource(string resourceName)
        {
            string result;
            var assembly = Assembly.GetExecutingAssembly();
            var foundResName = assembly.GetManifestResourceNames()
                    .FirstOrDefault(n => n.EndsWith(resourceName));

            if(string.IsNullOrEmpty(foundResName))
                throw new Exception("Unable to find resource '" + resourceName + "'!");

            using (var stream = assembly.GetManifestResourceStream(foundResName))
            {
                using (var reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }
    }
}