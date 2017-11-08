using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingCommonMethodToForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resimFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm ımg = new ImageForm();
            ımg.MdiParent = this;
            ımg.Show();
        }

        private void metinFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextForm txtForm = new TextForm();
            txtForm.MdiParent = this;
            txtForm.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((Child1)this.ActiveMdiChild).CloseForm();
            }
            catch
            {
                MessageBox.Show("Aktif Form Bulunamadı.");
            }
        }
    }
}
