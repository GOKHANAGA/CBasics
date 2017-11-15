using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList jsonList = new ArrayList();
        ArrayList personList = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add(Gender.Erkek);
            cmbGender.Items.Add(Gender.Kadın);
        }

        public string JSONSerialize(object graph)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer scJsonSerial = new DataContractJsonSerializer(typeof(Person));
            scJsonSerial.WriteObject(ms, graph);
            byte[] json = ms.ToArray();
            return Encoding.UTF8.GetString(json);
        }

        public Object JSONDeserializer(string json)
        {
            Person deserializedPerson = new Person();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer dcJsonDeserial = new DataContractJsonSerializer(typeof(Person));
            deserializedPerson = dcJsonDeserial.ReadObject(ms) as Person;
            return deserializedPerson;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.LastName = txtSurname.Text;
            person.BirthDate = Convert.ToDateTime(dtpBirthDate.Text);
            person.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.SelectedItem.ToString());

            /*----person objesini listeye ata----*/
            personList.Add(person);
            /*----person listesini listbox'a datasource olarak ata----*/
            lstPerson.Items.Clear();
            foreach (Person item in personList)
            {
                lstPerson.Items.Add(item);
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {

            foreach (Person item in personList)
            {
                jsonList.Add(JSONSerialize(item));
            }

            lstSerialized.Items.Clear();
            foreach (string item in jsonList)
            {
                lstSerialized.Items.Add(item);
            }

        }

        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            lstDeserialized.Items.Clear();
            foreach (string item in jsonList)
            {
                lstDeserialized.Items.Add(JSONDeserializer(item));
            }
        }
    }
}
