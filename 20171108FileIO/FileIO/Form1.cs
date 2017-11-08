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

namespace FileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string dosyaYolu = string.Empty;
        private void btnFile_Click(object sender, EventArgs e)
        {
            /*----Dosya Seçme Ekranı Getir----*/
            OpenFileDialog fd = new OpenFileDialog();

            /*----Dosyaları Filtrele----*/
            fd.Filter = "Metin Dosyaları |*.txt| Resim Dosyaları |*.png;*.jpg| Tüm Dosyalar |*.*";

            /*----Dosya Seçme İşlemini Yapmadan Başka İşlemleri Engelle----*/
            fd.ShowDialog();

            /*----Dosya Adını ve Yolunu Yakala----*/
            dosyaYolu = fd.FileName;

            /*----Yakalanan Dosya Yolunu Textboxta Göster----*/
            txtPath.Text = dosyaYolu;

        }

        private void btnFileRead_Click(object sender, EventArgs e)
        {
            /*----Dosyadan Okuma Yapma İçin Gerekli Olan StreamReader Sınıfından Yeni Bir Nesne Oluşturalım,Constuructor'ına Parametre Olarak verileri Okuyacağı Yolu Verelim----*/

            StreamReader sr = new StreamReader(dosyaYolu);

            /*----ReadToEnd() Metodu İle Dosyayı Sonuna Kadar Oku, txtFileText Dosyasının Text Özelliğine Ata----*/
            rchFileText.Text = sr.ReadToEnd();

            /*----Bağlantıyı işlem Bittikten Sonra Kapat----*/
            sr.Close();
        }

        private void btnFileWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(dosyaYolu);

                sw.Write(rchFileText.Text);
                MessageBox.Show("İşlem Başarıyla Gerçekleşti...");
                sw.Close();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(ioEx.Message);
            }
            finally
            {
                rchFileText.Text = string.Empty;
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            /*
             * File Modes-
             * Append -> Eski verinin devamına ekler...Yoksa Baştan Yazmaya Başlar...
             * OpenorCreate -> Dosya varsa açar yoksa yeni dosya oluşturur...
             * Open -> Dosyayı Açar,yazılan karakter kadar içeriğin başından itibaren değişiklik yapar...
             * Create -> Yeni bir dosya oluşturur, aynı isimde dosya varsa eskisini siler...
             * Truncate -> Belirtilen dosyanın içeriğini siler...
             * Createnew -> Yeni bir dosya oluşturur,aynı isimde dosya varsa hata döndürür...
             */

            FileStream fs = new FileStream(dosyaYolu, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            FileInfo fi = new FileInfo(dosyaYolu);

            byte[] byteDizisi = br.ReadBytes((int)fi.Length);
            string result = Encoding.UTF8.GetString(byteDizisi);

            rchBinaryText.Text = result;

            br.Close();
            fs.Close(); 
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(dosyaYolu, FileMode.Truncate);
            BinaryWriter bw = new BinaryWriter(fs);

            FileInfo fi = new FileInfo(dosyaYolu);

            string text = rchBinaryText.Text;
            bw.Write(text);
            MessageBox.Show("İşlem Başarılı");

            rchBinaryText.Text = string.Empty;
            bw.Close();
            fs.Close();

        }



    }
}
