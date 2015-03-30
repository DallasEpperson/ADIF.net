using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ADIF
{
    /// <summary>
    /// Provides IO and validation for Amateur Data Interchange Format files
    /// </summary>
    public static class ADIFIO
    {
        public static string ADIFVersion = "3.0.4";

        public static void Save(ADIFData data, string outputLocation)
        {
            //TODO determine if ADX or ADI from file ext, or error out
        }

        public static void SaveADX(ADIFData data, string outputLocation)
        {
            var serializer = new XmlSerializer(typeof(ADIFData));
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            serializer.Serialize(new FileStream(outputLocation, FileMode.Create), data, ns);
        }

        public static string ConvertToADX(ADIFData data)
        {
            var serializer = new XmlSerializer(typeof(ADIFData));
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var sw = new Utf8StringWriter())
            {
                serializer.Serialize(sw, data, ns);
                return sw.ToString();
            }
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }
    }
}
