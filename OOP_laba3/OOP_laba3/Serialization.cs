using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace OOP_laba3
{
    public class Serialization
    {
        private static void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
        }

        public static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            /* var xmlFormat = new XmlSerializer();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }*/
        }

        private static void SaveAsSoapFormat(object objGraph, string fileName)
        {
            var soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
        }

        private static object LoadFromBinaryFile(string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                object obj = binFormat.Deserialize(fStream);
                return obj;
            }
        }


        private static object LoadFromSoapFile(string fileName)
        {
            var soapFormat = new SoapFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                object obj = soapFormat.Deserialize(fStream);
                return obj;
            }
        }
    }
}