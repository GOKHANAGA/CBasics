using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Giyotin
{
    class JSON
    {
        public static string pathToCreateFile = @"C:\Users\Gökhan\Desktop\20171123Giyotin\Giyotin\TextDosyaları\JsonList.txt";
        

        public static string JSONSerialize(object graph)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer dcJsonSerialize = new DataContractJsonSerializer(graph.GetType());
            dcJsonSerialize.WriteObject(ms, graph);
            byte[] jsonBytes = ms.ToArray();
            return Encoding.UTF8.GetString(jsonBytes);
        }


        public static void DeserializeFromFile(string filePath)
        {
            Person deserializePerson = new Person();
            string jsonInfo="";
            StreamReader sr = new StreamReader(filePath);
            People.GetList().Clear();
            while (!sr.EndOfStream)
            {
                jsonInfo = sr.ReadLine();
                People.AddPerson(JSONDeserializer(jsonInfo) as Person);
            }

        }

        private static Object JSONDeserializer(string json)
        {
            Person deserializedPerson = new Person();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer dcJsonDeserial = new DataContractJsonSerializer(typeof(Person));
            deserializedPerson = dcJsonDeserial.ReadObject(ms) as Person;
            return deserializedPerson;
        }


    }
}
