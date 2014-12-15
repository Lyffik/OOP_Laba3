using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using OOP_Laba3;

namespace OOP_laba3
{
    public class IniFormatter : IFormatter
    {
        private StreamReader streamReader;
        private readonly bool isListFilled = false;

        public IniFormatter()
        {
            Context = new StreamingContext(StreamingContextStates.All);
        }

        public object Deserialize(Stream serializationStream)
        {
            streamReader = new StreamReader(serializationStream);
            var result = new List<Transport>();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                result.Add(GetObject(line) as Transport);
            }
            streamReader.Close();
            return result;
        }

        public void Serialize(Stream serializationStream, object graph)
        {
            var streamWriter = new StreamWriter(serializationStream);
            var transports = graph as IEnumerable;
            foreach (var transport in transports)
            {
                SerializeObject(transport, streamWriter);
                streamWriter.Write("\r\n");
            }
            streamWriter.Close();
        }

        public ISurrogateSelector SurrogateSelector { get; set; }
        public SerializationBinder Binder { get; set; }
        public StreamingContext Context { get; set; }

        private object GetObject(string objectString)
        {
            var currentString = objectString;
            if (objectString[objectString.Length - 1] == ';')
            {
                currentString = objectString.Remove(objectString.Length - 1);
            }
            var listString = "";
            if (objectString.IndexOf("{") != -1 && objectString.IndexOf("}") != -1)
            {
                listString = currentString.Remove(currentString.IndexOf("}") + 1).Substring(currentString.IndexOf("{"));
                currentString = currentString.Replace(listString, "");
            }
            var classDictionary = CreateDictionary(currentString);
            var className = classDictionary["ClassName"];
            var resObject = FormatterServices.GetUninitializedObject(Type.GetType(className));
            var members = FormatterServices.GetSerializableMembers(resObject.GetType(), Context);
            var data = new object[members.Length];
            for (var i = 0; i < members.Length; ++i)
            {
                var fieldInfo = ((FieldInfo) members[i]);
                var fieldName = fieldInfo.Name;
                if (fieldName.IndexOf("<") != -1 && fieldName.IndexOf(">") != -1)
                {
                    fieldName = fieldName.Substring(fieldName.IndexOf("<") + 1,
                        fieldName.IndexOf(">") - fieldName.IndexOf("<") - 1);
                }
                if (!classDictionary.ContainsKey(fieldName))
                    throw new SerializationException("Missing field value : " + fieldInfo.Name);
                if (fieldInfo.FieldType.Name.Contains("List"))
                {
                    data[i] = GetObjectList(listString);
                }
                else
                {
                    data[i] = Convert.ChangeType(classDictionary[fieldName], fieldInfo.FieldType);
                }
            }
            return FormatterServices.PopulateObjectMembers(resObject, members, data);
        }

        private List<Motor> GetObjectList(string listString)
        {
            var result = new List<Motor>();
            listString = listString.Remove(0, 1);
            listString = listString.Remove(listString.Length - 1);
            if (listString != "")
            {
                var objectsStrings = listString.Split(';');
                foreach (var objectString in objectsStrings)
                {
                    if (objectString!="")
                    {
                        result.Add(GetObject(objectString) as Motor);
                    }
                   
                }
            }
            return result;
        }

        private Dictionary<string, string> CreateDictionary(string fieldsInfo)
        {
            var result = new Dictionary<string, string>();
            var fields = fieldsInfo.Split(',');
            foreach (var field in fields)
            {
                var info = field.Split('=');
                result[info[0].Trim()] = info[1].Trim();
            }
            return result;
        }

        private void SerializeObject(object graph, StreamWriter streamWriter)
        {
            var members = FormatterServices.GetSerializableMembers(graph.GetType(), Context);
            var objectsData = FormatterServices.GetObjectData(graph, members);
            streamWriter.Write("ClassName={0}", graph.GetType().FullName);
            for (var i = 0; i < objectsData.Length; ++i)
            {
                var name = members[i].Name;
                if (name.IndexOf("<") != -1 && name.IndexOf(">") != -1)
                {
                    name = name.Substring(name.IndexOf("<") + 1, name.IndexOf(">") - name.IndexOf("<") - 1);
                }
                streamWriter.Write(",{0}={1}", name, objectsData[i]);
                if (objectsData[i].ToString().IndexOf("List") != -1)
                {
                    streamWriter.Write("{");
                    var transports = objectsData[i] as IEnumerable;
                    foreach (var transport in transports)
                        SerializeObject(transport, streamWriter);
                    streamWriter.Write("}");
                }
            }
            streamWriter.Write(";");
        }
    }
}