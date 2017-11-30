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
        /*----Instance for lists----*/
        MovieGenres genreList = MovieGenres.GetInstance();
        Movies movieList = Movies.GetInstance();

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            /*----If there will be a discount in movie,check the checkBox----*/
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
            /*----Get Values in dictionary as list to comboBox----*/
            cmbGenre.DataSource = genreList.GetComponents().Values.ToList();
            /*----At the load give today's date for the movie relase date----*/
            dtpStartOfRelease.MinDate = DateTime.Now.Date;
            /*----Movie release date cannot end in the same day of release----*/
            dtpEndOfRelease.MinDate = dtpStartOfRelease.Value.AddDays(1);
        }

        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            /*----Save new movie to our movieList----*/
            Movie newMovie = new Movie();
            newMovie.MovieName = txtName.Text;
            newMovie.Genre = GetMovieGenreByName();
            newMovie.Release.FirstDayOfRelease = dtpStartOfRelease.Value;
            newMovie.Release.LastDayOfRelease = dtpEndOfRelease.Value;
            if (chkDiscount.Checked)
            {
                /*----If checkBox checked for discount then get the discount rate----*/
                newMovie.DiscountRate = Convert.ToDouble(txtDiscount.Text);
            }
            else
            {
                /*----else give the discount as 0----*/
                newMovie.DiscountRate = 0;
            }

            movieList.AddComponent(newMovie);

            /*----Show the feedback to user for process is succesfully done----*/
            MessageBox.Show("İşleminiz Başarılı Gerçekleşmiştir.",
                            "Film Eklendi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            /*----Clear the form after adding to list----*/
            ClearForm();
        }


        /*----Get the MovieGenre object from selected name in combobox----*/
        private MovieGenre GetMovieGenreByName()
        {
            MovieGenre selectedMovieGenre = new MovieGenre();
            foreach (KeyValuePair<string, MovieGenre> item in genreList.GetComponents())
            {
                /*----Get values and keys from out dictionary for checking values in combobox----*/
                if (cmbGenre.SelectedValue.ToString() == item.Value.GenreName)
                {
                    /*----Get the selected movie genre from comparison of combobox value and genre name----*/
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

        private void dtpStartOfRelease_ValueChanged(object sender, EventArgs e)
        {
            /*----When the release date changes end of release also changes simultaneously but one day more----*/
            /*----Movie release date cannot end in the same day of release----*/
            dtpEndOfRelease.MinDate = dtpStartOfRelease.Value.AddDays(1);
        }
    }
}
