using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giyotin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = string.Empty;
        int x = 0, y = 0;
        static Random rndNumber = new Random();
        public static List<string> giyotinName = new List<string>();


        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Metin Dosyası |*.txt";
            ofDialog.ShowDialog();
            filePath = ofDialog.FileName;
            int index = filePath.LastIndexOf(@"\");
            string fileName = filePath.Substring(index, filePath.Length - index);

            FileOperationscs.FileRead(filePath);
            FileOperationscs.ClearText(filePath.Substring(0, index) + "\\JsonList.txt");

            foreach (Person p in People.GetList())
            {
                FileOperationscs.FileWrite(filePath.Substring(0, index) + "\\JsonList.txt", JSON.JSONSerialize(p));
            }

            JSON.DeserializeFromFile(filePath.Substring(0, index) + "\\JsonList.txt");

            foreach (Person p in People.GetList())
            {
                CheckBox chk = new CheckBox();
                chk.Name = p.ToString();
                chk.Text = p.ToString();
                chk.Location = new Point(x, y);
                chk.Width = 200;
                chk.CheckedChanged += checkBox_CheckedChanged;
                pnlPeople.Controls.Add(chk);
                y += 25;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public static int ShuffleTheList()
        {
            HashSet<Person> copyPeople = new HashSet<Person>();
            giyotinName.Clear();
            foreach (Person item in People.GetList())
            {
                copyPeople.Add(item);
            }
            int count = 0;
            while (!(copyPeople.Count == 0))
            {
                Person rndPerson = (copyPeople.ElementAt(rndNumber.Next(copyPeople.Count)));
                string person = rndPerson.ToString();
                giyotinName.Add(person);
                copyPeople.Remove(rndPerson);
                count++;
            }
            return count;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ShuffleTheList();
            GiyotinForm gyForm = new GiyotinForm();
            gyForm.Show();
            this.Hide();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox chk in pnlPeople.Controls)
            {
                if (chk == sender)
                {
                    int index = pnlPeople.Controls.IndexOf(chk);
                    string personInfo = (sender as CheckBox).Name;
                    int nameIndex = personInfo.IndexOf(" ");
                    string name = personInfo.Substring(0, nameIndex);
                    string surname = personInfo.Substring(nameIndex + 1, personInfo.Length - nameIndex - 1);
                    Person checkedPerson = new Person(name, surname);
                    pnlPeople.Controls.Remove(chk);
                    People.DeletePerson(index);
                }

            }

        }


    }
}
