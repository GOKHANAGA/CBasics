using CinemaComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilentCinema
{
    public partial class AddMovieGenre : Form
    {
        public AddMovieGenre()
        {
            InitializeComponent();
        }

        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            MovieGenre addNewGenre = new MovieGenre();
            MovieGenres genres = MovieGenres.GetInstance();
            addNewGenre.GenreName = txtGenreName.Text;
            if (chkDiscount.Checked)
            {
                /*----If discount is checked then gen the discount value----*/
                addNewGenre.DiscountRate = Convert.ToDouble(txtDiscount.Text);
            }
            else
            {
                addNewGenre.DiscountRate = 0;
            }
            /*----Add the new Genre to the list----*/
            genres.AddComponent(addNewGenre);

            MessageBox.Show("İşleminiz Başarılı Gerçekleşmiştir.",
                            "Film Türü Eklendi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            ClearForm();
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount.Checked)
            {
                /*----If discount checkBox is checked then show textbox and label----*/
                txtDiscount.Visible = true;
                lblDiscount.Visible = true;
            }
            else
            {
                txtDiscount.Visible = false;
                lblDiscount.Visible = false;
                txtDiscount.Text = string.Empty;
            }
        }

        private void ClearForm()
        {
            txtDiscount.Text = string.Empty;
            txtGenreName.Text = string.Empty;
            chkDiscount.Checked = false;
        }


    }
}





