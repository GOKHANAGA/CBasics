using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171102CV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblExperience_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblTitleName.Text = txtName.Text;
            lblTitleName.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTextBackgrounOnHover(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                ((TextBox)sender).BackColor = Color.Bisque;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
            {
                ((MaskedTextBox)sender).BackColor = Color.Bisque;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.CheckBox")
            {
                ((CheckBox)sender).BackColor = Color.Bisque;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.RichTextBox")
            {
                ((RichTextBox)sender).BackColor = Color.Bisque;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ((ComboBox)sender).BackColor = Color.Bisque;
            }
        }

        private void ChangeBackOnLeave(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.TextBox") 
            { 
                ((TextBox)sender).BackColor = Color.White;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
            {
                ((MaskedTextBox)sender).BackColor = Color.White;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.CheckBox")
            {
                ((CheckBox)sender).BackColor = Color.LightSkyBlue;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.RichTextBox")
            {
                ((RichTextBox)sender).BackColor = Color.White;
            }
            else if (sender.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ((ComboBox)sender).BackColor = Color.White;
            }


        }

        // for military delayed...
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                txtMilitaryDelayed.Visible = true;
            }
        }

        //for military obligation is gone...
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                txtMilitaryDelayed.Visible = false;
            }
        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked)
            {
                chkFemale.Checked = false;
                pnlMilitary.Visible = true;
            }
            else
            {
                pnlMilitary.Visible = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;

            }

        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked)
            {
                chkMale.Checked = false;
                pnlMilitary.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aday Adı: " + txtName.Text + "\n\n" + "Mezun Olduğu Bölüm :" + txtDepartment.Text +"\n\n"+"Telefon No :"+txtPhone.Text);
        }
    }
}
