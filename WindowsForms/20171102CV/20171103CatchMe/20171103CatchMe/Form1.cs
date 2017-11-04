using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171103CatchMe
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

        //private void ChangePlaceOfControl(object sender, EventArgs e)
        //{
        //    Random rand = new Random();
        //    Random rand1 = new Random();
        //    int x = rand.Next(0, (this.Width - btnCatch.Width));
        //    int y = rand1.Next(0, (this.Height - btnCatch.Height));
        //    ((Control)sender).Location = new Point(x,y);
        //}


        //Mouse Enter mouse herhangi bir yerine gelir gelmez işlemi yapar...
        //Mouse Hover mouse üzerine gelince işlem yapar...

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, (this.Width - (btnCatch.Size.Width+25)));
            int y = rand.Next(0, (this.Height - (btnCatch.Size.Height+25)));
            btnCatch.Location = new Point(x, y);
        }

    }
}
