using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171106Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*----We Created Our Dictionary for our cities, 
         * int key will hold the code for cities and 
         * string is name of the cities----
         */

        Dictionary<int, string> cityDictionary = new Dictionary<int, string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int plakaKodu;

            try
            {
                plakaKodu = int.Parse(txtCityCode.Text);

                /*----Addition of key value pairs to the container----*/
                cityDictionary.Add(plakaKodu, txtCityName.Text);
            }
            catch
            {
                MessageBox.Show("Plaka Kodunu Doğru Girmediniz");
            }
            finally
            {
                txtCityName.Text = string.Empty;
                txtCityCode.Text = string.Empty;
            }
        }

        private void btnMoveToList_Click(object sender, EventArgs e)
        {
            lstRecords.Items.Clear();
            /*---- We will get our items as key value pairs and then 
             * we will write them to list seperately as key+value ----*/
            foreach (KeyValuePair<int, string> items in cityDictionary)
            {
                lstRecords.Items.Add(items.Key + " " + items.Value);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseCancel())
            {
                e.Cancel = true;
                MessageBox.Show("Kaldığınız Yerden Devam Edebilirsiniz.", "Kapatma İptal Edildi...", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güle Güle","Kapanıyor...",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }


        public static bool CloseCancel()
        {
            const string message = "Çıkmaz İstediğinizden emin misiniz ?";
            const string caption = "Dikkat!!!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

    }
}
