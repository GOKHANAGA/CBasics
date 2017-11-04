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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string chosen;
        frmDownloadScreen frmDS = new frmDownloadScreen();
        private void rdbtnVS2013_CheckedChanged(object sender, EventArgs e)
        {
            CommonCommands(rdbtnVS2013.Text);
        }

        private void rdbtnVS2015_CheckedChanged(object sender, EventArgs e)
        {
            CommonCommands(rdbtnVS2015.Text);
        }

        private void rdbtnMSSQL2014_CheckedChanged(object sender, EventArgs e)
        {
            CommonCommands(rdbtnMSSQL2014.Text);
        }

        private void rdbtnMSOffice2017_CheckedChanged(object sender, EventArgs e)
        {
            CommonCommands(rdbtnMSOffice2017.Text);
        }

        private void CommonCommands(string commandText)
        {
            chosen = commandText;
            frmDS.Show();
            this.Hide();
        }
    }
}
