using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm1 cfrm1 = new ChildForm1();
            cfrm1.MdiParent = this;
            cfrm1.Show();
        }

        private void form2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm2 cfrm2 = new ChildForm2();
            cfrm2.MdiParent = this;
            cfrm2.Show();
        }
    }
}
