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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        MovieGenres genreList = MovieGenres.GetInstance();
        Movies movieList = Movies.GetInstance();

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount.Checked)
            {
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

        private void AddMovie_Load(object sender, EventArgs e)
        {
            cmbGenre.DataSource = genreList.GetComponents().Values.ToList();
        }

        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();
            newMovie.MovieName = txtName.Text;
            newMovie.Genre = GetMovieGenreByName();
            newMovie.Release.FirstDayOfRelease = dtpStartOfRelease.Value;
            newMovie.Release.LastDayOfRelease = dtpEndOfRelease.Value;
            if (chkDiscount.Checked)
            {
                newMovie.DiscountRate = Convert.ToDouble(txtDiscount.Text);
            }
            else
            {
                newMovie.DiscountRate = 0;
            }

            movieList.AddComponent(newMovie);

            MessageBox.Show("İşleminiz Başarılı Gerçekleşmiştir.",
                            "Film Eklendi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            ClearForm();
        }


        /*----Get the MovieGenre object from selected name in combobox----*/
        private MovieGenre GetMovieGenreByName()
        {
            MovieGenre selectedMovieGenre = new MovieGenre();
            foreach (KeyValuePair<string, MovieGenre> item in genreList.GetComponents())
            {
                if (cmbGenre.SelectedValue.ToString() == item.Value.GenreName)
                {
                    selectedMovieGenre = item.Value;
                }
            }

            return selectedMovieGenre;
        }

        private void ClearForm()
        {
            txtDiscount.Text = string.Empty;
            txtName.Text = string.Empty;
            chkDiscount.Checked = false;
        }
    }
}
