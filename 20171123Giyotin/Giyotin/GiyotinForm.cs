using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giyotin
{
    public partial class GiyotinForm : Form
    {
        public GiyotinForm()
        {
            InitializeComponent();
        }
        List<Label> rndLabels = new List<Label>();
        Form1 frm1=new Form1();
        Random rndNumber = new Random();
        int returnIndex;
        int timeLimit = 50;
        int timeCount = 1;

        private void GiyotinForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AddLabel()
        {
            if (Form1.giyotinName.Count - 1 >= returnIndex)
            {
                string name = Form1.giyotinName[returnIndex];
                Label giyotinLbl = new Label();
                giyotinLbl.Text = name;
                giyotinLbl.Location = new Point(rndNumber.Next(0, this.Size.Width - 60), rndNumber.Next(0, this.Size.Height - 60));
                giyotinLbl.ForeColor = GetRndColor();
                giyotinLbl.AutoSize = true;
                giyotinLbl.Font = new Font(giyotinLbl.Font.Name, 15F);
                rndLabels.Add(giyotinLbl);
                this.Controls.Add(giyotinLbl);

                returnIndex++;
            }
            else
            {
                returnIndex = 0;
                Form1.ShuffleTheList();
                string name = Form1.giyotinName[returnIndex];
                Label giyotinLbl = new Label();
                giyotinLbl.Text = name;
                giyotinLbl.Location = new Point(rndNumber.Next(0, this.Size.Width - 50), rndNumber.Next(0, this.Size.Height - 50));
                giyotinLbl.AutoSize = true;
                giyotinLbl.Font = new Font(giyotinLbl.Font.Name, 15F);
                rndLabels.Add(giyotinLbl);
                this.Controls.Add(giyotinLbl);
                timeCount++;
                returnIndex++;
            }
        }


        private void DeleteLabel()
        {
            int size = rndNumber.Next(0, rndLabels.Count - 1);
            this.Controls.Remove(rndLabels[size]);
            rndLabels.Remove(rndLabels[size]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeCount <= timeLimit)
            {
                AddLabel();
                timeCount++;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeCount > 2)
            {
                DeleteLabel();
                timeCount--;
            }
            else
            {
                rndLabels[0].Location = new Point((this.Width / 2)-100, this.Height / 2);
                rndLabels[0].ForeColor = GetRndColor();
            }
        }

        private Color GetRndColor()
        {
            return Color.FromArgb(rndNumber.Next(256), rndNumber.Next(256), rndNumber.Next(256));
        }

        private void GiyotinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
