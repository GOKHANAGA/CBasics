using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171103DownloadManager
{
    public partial class frmDownloadScreen : Form
    {
        public frmDownloadScreen()
        {
            InitializeComponent();
        }

        private void frmDownloadScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;  //timer1.start()
            lblInfo.Text = Form1.chosen + " indiriliyor";
            tmrProgress.Enabled = true; //tmrProgress.start()
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {

            lblDateTime.Text = DateTime.Now.ToString();
            //Progress Bar 100 olana kadar her saniyede çalışacak Tick Metodu-----
            if (progressBar1.Value < 100)
            {
                lblPercentage.Text = "%" + progressBar1.Value;
                //Progress Bar değeri 100'den küçükse  her saniyede 1 birim arttır----
                progressBar1.Increment(1);
            }
            else
            {
                //İşlem bittiği zaman timerı devre dışı bırak ve ekrana bildirim göster---
                tmrProgress.Enabled = false; //tmrProgress.stop()
                MessageBox.Show(Form1.chosen + " İndirilmiştir");
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmrProgress.Enabled = false;
            progressBar1.Value = 0;
            MessageBox.Show(Form1.chosen + "indirmesi iptal edilmiştir.");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrProgress.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            tmrProgress.Enabled = true;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }


    }
}
