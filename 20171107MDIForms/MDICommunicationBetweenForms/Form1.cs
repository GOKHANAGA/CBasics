using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDICommunicationBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*------Formlardan Instance aldık------*/
            FirstForm fForm = new FirstForm();
            SecondForm sForm = new SecondForm();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i + j;
                    btn.Text = "btn" + i + j;
                    btn.Size = new Size(50,50);
                    btn.Location = new Point(i * 50 + 5, j * 50 + 5);

                    //btn.Click+=new EventHandler(btnClick);
                    btn.Click += btnClick;


                    fForm.Controls.Add(btn);
                }
            }

            fForm.MdiParent = this;
            sForm.MdiParent = this;

            /*----Formun Başlangıç Lokasyonunu Manual olarak ayarlayıp değerleri elle veriyoruz---FormStartPosition-->Enum yapıdadır-----*/
            sForm.StartPosition = FormStartPosition.Manual;
            sForm.Location = new Point(1+fForm.Size.Width, 0);
            fForm.Show();
            sForm.Show();
        }

        public void btnClick(object sender,EventArgs e)
        {
            //Butona Tıklandığında Buton Form1 den Form2 ye taşınacak----
            //..................(Button)sender;
            Button btn = sender as Button;
            Button btnToMove = new Button();
            btnToMove = Clone(btn);
            //Aktif olan formu almak için kullanılan yapı----
            Form owner = this.ActiveMdiChild;


            //MDIChildren ile alt formlar arasında dolaşmak için döngü kuruyoruz----
            foreach (Form form in this.MdiChildren)
            {
                /*----btnToMove Direkt olarak form içerisindeki butonu aldığı için(instnce olarak alınmadıpı için)
                 *    eklemeden sonra önceki formdan alınıp ötekine eklenir----*/


                if (owner is FirstForm && form is SecondForm)
                /*----Owner FirstForm ise ve form SecondForm ise 
                 *    btnToMove u form'a ekle---(form-->SecondForm bu kontrolde)----*/
                {
                    form.Controls.Add(btnToMove);
                    break;
                }
                else if (owner is SecondForm && form is FirstForm)
                /*----Owner SecondForm ise ve form FirstForm ise 
                 *    btnToMove u form'a ekle---(form-->FirstForm bu kontrolde)----*/
                {
                    form.Controls.Add(btnToMove);
                    break;
                }
            }
        }

        private Button Clone(Button c){
            Button btn =new Button();
            btn.Size = c.Size;
            btn.Text = c.Text;
            btn.Name = c.Name;
            btn.Location = c.Location;
            btn.BackColor = Color.Red;

            return btn;
        }
    }
}
