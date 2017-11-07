using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _20171107Part1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*----Ekrana 1'den girilen sayıya kadar saydırma işlemi----*/
        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            string numbers="";
            int limit=int.Parse(txtLimit.Text);
            for (int i = 0; i < limit; i++)
            {
                numbers += i+1;
                numbers += "\n";
            }


            MessageBox.Show(numbers);
        }

        /*----Ekrana yazılan mesajı girilen değer kadar yazdırma işlemi----*/
        private void btnShow_Click(object sender, EventArgs e)
        {
            string screenMessage = "";
            string message = txtMessage.Text;
            int messageCount = int.Parse(txtMessageCount.Text);
            for (int i = 0; i < messageCount; i++)
            {
                screenMessage += message;
                screenMessage += "\n";
            }
            MessageBox.Show(screenMessage);
        }


        /*----İki adet textboxtan aldığı değerlerin arasındaki asal değerleri bulan click event'i----*/
        private void btnGetPrime_Click(object sender, EventArgs e)
        {
            string primeNumbers="";
            int primeCheckNr1 = int.Parse(txtFirstNr.Text);
            int primeCheckNr2 = int.Parse(txtSecondNr.Text);
            
            //----eğer ilk sayımız 1 ise 2 den balaması için artırmamız gerekir----
            if (primeCheckNr1 == 1)
            {
                primeCheckNr1++;
            }
            /*----Verilen Sayılar için Asallık kontrolü----*/
            for (int i = primeCheckNr1; i < primeCheckNr2; i++)
            {
                int ctrl = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ctrl = 1;
                        break;
                    }
                }
                if (ctrl == 1)
                {

                }
                else
                {
                    primeNumbers += i;
                    primeNumbers += "\n";
                }
            }

            MessageBox.Show(primeNumbers,
                            "Girilen Değerler Arasındaki Asallar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }


        /*----Textbox'a girilen değerin ondalık olup olmaması durumunu ekranda 
         * gösteren click event'i---- 
*/
        private void btnGetFraction_Click(object sender, EventArgs e)
        {
            double enteredNumber = double.Parse(txtNrToFraction.Text);
            int convertedNumber = (int)enteredNumber;
            if (enteredNumber == convertedNumber)
            {
                MessageBox.Show("Sayı Ondalık Değildir",
                                "Sonuç",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sayı Ondalıktır",
                                "Sonuç",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }


        /*
         * ----Ekranda Bulunan iki textboxtan decimal veya binary olarak alınan değerleri bir diğerine 
         * ----çevirip sonucu listbox ta gösterme işlemi yapan event------
         */
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string binaryToDecimal;
            long binToDecValue;
            string message;
            int decimalToBinary;

            if (txtBinary.Text != string.Empty)
            {
                lstConvertedNumber.Items.Clear();
                binaryToDecimal = txtBinary.Text;
                binToDecValue = Convert.ToInt64(binaryToDecimal, 2);
                message = binToDecValue.ToString();
                lstConvertedNumber.Items.Add(txtBinary.Text + "--> :" + message);
                txtBinary.Text = string.Empty;
            }
            else if (txtDecimal.Text != string.Empty)
            {
                lstConvertedNumber.Items.Clear();
                decimalToBinary = int.Parse(txtDecimal.Text);
                message = Convert.ToString(decimalToBinary, 2);
                lstConvertedNumber.Items.Add(txtDecimal.Text + "--> :\n" + message);
                txtDecimal.Text = string.Empty;

            }

        }


        Color cl = new Color();
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            cl = Color.Red;
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            this.BackColor = cl;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            cl = Color.Green;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            cl = Color.DarkBlue;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            cl = Color.Orange;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            cl = Color.Purple;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //salise değerini integer olarak atamasını yapıyoruz....
            int splitSecond=int.Parse(lblSplitSecond.Text);
            lblSplitSecond.Text = (splitSecond + 1).ToString();
            if (lblSplitSecond.Text == "99")
            {
                int second = int.Parse(lblSecond.Text);
                lblSecond.Text = (second + 1).ToString();
                lblSplitSecond.Text = "00";
            }
            if (lblSecond.Text == "60")
            {
                int minute = int.Parse(lblMinute.Text);
                lblMinute.Text = (minute + 1).ToString();
                lblSecond.Text = "00";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            /*----Durdur Butonuna basılırsa kronometreyi sıfırla----*/
            timer.Enabled = false;
            lblSecond.Text = "00";
            lblMinute.Text = "00";
            lblSplitSecond.Text = "00";
        }

        private void btnStartFilling_Click(object sender, EventArgs e)
        {
            progressTimer.Enabled = true;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void btnClearBar_Click(object sender, EventArgs e)
        {
            progressTimer.Enabled = false;
            progressBar1.Value = 0;
        }


        /*----TextBox ta yazılı olan değeri alabilmek ve Tick metodunda da kullanabilmek için global olarak bir
         * integer tanımlıyorum , değer saydırma işlemi için de bir counter----
         */
        int txtValue,counter=1;
        private void btnStartProgressTime_Click(object sender, EventArgs e)
        {
            tmrTimeLimited.Enabled = true;
            txtValue = int.Parse(txtTimerToProgress.Text);
        }

        /*----İşlemi sıfırladığımızda textbox ve progress bar sıfırlanır----*/
        private void btnClearProgressTime_Click(object sender, EventArgs e)
        {
            tmrTimeLimited.Enabled = false;
            txtTimerToProgress.Text = string.Empty;
            progressBar2.Value = 0;
        }


        private void tmrTimeLimited_Tick(object sender, EventArgs e)
        {
            if (counter <= txtValue) 
            {
            progressBar2.Increment(10);
            counter++;
            }
            
        }

        /*----DateTimePicker ile aldığımız datetime değeri ile bugün arasındaki toplam gün sayısını bulup mesaj
         *---- kutusu ile ekrana yazdırmaya yarayan click eventi----
         */
        private void btnLivedDays_Click(object sender, EventArgs e)
        {
            DateTime birthDate = birthDatePicker.Value;
            int days =Convert.ToInt32((DateTime.Now - birthDate).TotalDays);
            string message = ("Doğum Gününüz: " + birthDate.ToShortDateString() +
                            "\n\nBugünün Tarihi: " + DateTime.Now.ToShortDateString() +
                            "\n\nYaşadığınız Gün Sayısı: " + days.ToString());
            MessageBox.Show(message);
        }



    }
}
