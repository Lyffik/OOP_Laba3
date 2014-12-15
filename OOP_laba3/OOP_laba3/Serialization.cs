using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using OOP_Laba3;

namespace OOP_laba3
{
    public class Serialization
    {
        public static void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
        }

        public static void SaveAsXmlFormat(object objGraph, string fileName, Dictionary<string, Type> dictionary)
        {
            var xmlFormat = new XmlSerializer(typeof (Transport), dictionary.Values.ToArray());
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }

        public static void SaveListAsBinaryFormat(List<Transport> list, string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, list);
            }
        }

        public static void SaveListAsXmlFormat(List<Transport> list, string fileName,
            Dictionary<string, Type> dictionary)
        {
            var xmlFormat = new XmlSerializer(typeof (List<Transport>), dictionary.Values.ToArray());
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, list);
            }
        }

        public static void SaveAsIniFormat(object objGraph, string fileName)
        {
            var simpleFormatter = new IniFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                simpleFormatter.Serialize(fStream, objGraph);
            }
        }

        public static List<Transport> LoadFromIni(string fileName)
        {
            var formatter = new IniFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
                return (List<Transport>) formatter.Deserialize(fStream);
        }

        public static object LoadFromBinaryFile(string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                object obj = binFormat.Deserialize(fStream);
                return obj;
            }
        }


        public static Transport LoadFromXmlFile(string fileName, Dictionary<string, Type> dictionary)
        {
            var formatter = new XmlSerializer(typeof (Transport), dictionary.Values.ToArray());
            using (Stream fStream = File.OpenRead(fileName))
                return (Transport) formatter.Deserialize(fStream);
        }

        public static List<Transport> LoadListFromBinaryFile(string fileName)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                return (List<Transport>) binFormat.Deserialize(fStream);
            }
        }


        public static List<Transport> LoadListFromXmlFile(string fileName, Dictionary<string, Type> dictionary)
        {
            var formatter = new XmlSerializer(typeof (List<Transport>), dictionary.Values.ToArray());
            using (Stream fStream = File.OpenRead(fileName))
                return (List<Transport>) formatter.Deserialize(fStream);
        }
    }
}