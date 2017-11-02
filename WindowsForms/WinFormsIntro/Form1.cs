using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //Select the little right arrow on the comboBox to edit items inside it......
            string city = cmbCity.Text;
            if (txtName.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show(string.Format("Merhaba {0},Hoşgeldiniz. \nŞehriniz: {1}", txtName.Text, cmbCity.Text));

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış lütfen kontrol edin.");
            }

            if (chkOgrenci.Checked == true)
            {
                MessageBox.Show("Öğrenci");
            }
            else
            {
                MessageBox.Show("Öğrenci Değil");
            }
        }


        /*Inside the properties and under events --> textchanged i seç bu metot otomatik oluşur..*/
        /*Her yazılan harften sonra tetiklenir messagebox gösterir.....*/
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }


        //ComboBox tan seçim yapıldığında veya yapılmış olan seçim değiştirildiğinde çalışan event----

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCityShow.Text = cmbCity.Text;
            lblCityShow.Visible = true;
            lblCityShow.BackColor = Color.Red;
            lblCityShow.AutoSize = false;
            lblCityShow.Size = new Size(60, 100);
        }

        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("deneme");
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnSave, "İşlemi Kaydetmek için Bu Butona Tıklayınız...");
        }

        private void lblCheck_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.lblCheck, "Kullanıcı Öğrenci ise Seçiniz.");
        }


        //Check box durumu değiştirilirse işlemek için checkbox ın checkedChage Event i
        //private void chkOgrenci_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkOgrenci.Checked)
        //    {
        //        MessageBox.Show("Öğrenci");
        //    }
        //    }
    }
}
