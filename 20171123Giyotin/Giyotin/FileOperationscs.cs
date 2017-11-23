using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giyotin
{
    class FileOperationscs
    {

        public static void FileRead(string path)
        {
            People people=People.GetPeople();
            StreamReader sr = new StreamReader(path);
            string name="", surname="";
            while (!sr.EndOfStream)
            {
                string personInfo = sr.ReadLine();
                int nameIndex = personInfo.IndexOf(" ");
                name = personInfo.Substring(0, nameIndex);
                surname = personInfo.Substring(nameIndex+1, personInfo.Length - nameIndex-1);
                Person listPerson = new Person(name, surname);
                People.AddPerson(listPerson);
                JSON.JSONSerialize(listPerson);
            }
            
        }

        public static void FileWrite(string path,string textToFile)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path,true);

                sw.WriteLine(textToFile);
                sw.Close();
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }

        public static void ClearText(string path)
        {
            try
            {
                File.WriteAllText(path, string.Empty);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }

        
    }
}
