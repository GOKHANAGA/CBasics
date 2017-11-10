using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalarSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string timeCheck;
        string dateCheck;
        SoundPlayer sp = new SoundPlayer();
        int counter;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*----Program başlarken o anki saati alarak mskTime componentinin text özelliğine ata----*/
            mskTime.Text = DateTime.Now.ToShortTimeString();

            /*----İlk açılışta açılış saatini başlıkta göster----*/
            this.Text = DateTime.Now.ToLongTimeString();
        }

        private void tmrHour_Tick(object sender, EventArgs e)
        {
            /*----Her saniye sistemin saatini saniye ile alarak formun başlığına göster----*/
            this.Text = DateTime.Now.ToLongTimeString();
        }



        private void btnStartAlarm_Click(object sender, EventArgs e)
        {
            counter = 0;
            timeCheck = mskTime.Text;
            dateCheck = dtpDate.Text;
            tmrTimeCheck.Start();
            MessageBox.Show(string.Format("Alarm {1} {0} olarak kuruldu", dateCheck, timeCheck),
                            "Alarm Kuruldu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            /*----Butona Basılınca Formu Görev Çubuğunda Gizle----*/
            this.ShowInTaskbar = false;
        }

        private void tmrTimeCheck_Tick(object sender, EventArgs e)
        {
            if (timeCheck == DateTime.Now.ToShortTimeString() && dateCheck == DateTime.Now.ToLongDateString())
            {
                tmrTimeCheck.Stop();
                tmrAlarmOperations.Start();
            }
        }

        private void tmrAlarmOperations_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                sp.SoundLocation = string.Format(@"{0}\alarmSesi.wav", Application.StartupPath);
                sp.PlayLooping();
                counter++;
            }

            if (Convert.ToDateTime(timeCheck).AddMinutes(1).ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                btnAlarmStop_Click(sender, e);
            }

            this.ShowInTaskbar = true;
            this.BringToFront();
            this.TopMost = true;


            for (int i = 0; i < 1000; i++)
            {
                pctHour.Left += 2;
                pctHour.Left -= 2;
                pctHour.Top += 2;
                pctHour.Top -= 2;
            }

            if (txtAlarmText.BackColor == Color.White || txtAlarmText.BackColor == Color.Red)
            {
                txtAlarmText.BackColor = Color.Yellow;
                txtAlarmText.ForeColor = Color.Red;
            }
            else
            {

                txtAlarmText.BackColor = Color.Red;
                txtAlarmText.ForeColor = Color.Yellow;
            }

        }

        private void btnAlarmStop_Click(object sender, EventArgs e)
        {
            tmrAlarmOperations.Stop();
            sp.Stop();
        }
    }
}
