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
    public partial class GenreDiscount : Form
    {
        MovieGenres genreList = MovieGenres.GetInstance();
        public GenreDiscount()
        {
            InitializeComponent();
        }



        /*----Get the MovieGenre object from selected name in combobox----*/
        private MovieGenre GetMovieGenreByName()
        {
            MovieGenre selectedMovieGenre = new MovieGenre();
            foreach (KeyValuePair<string, MovieGenre> item in genreList.GetComponents())
            {
                if (cmbGenres.SelectedValue.ToString() == item.Value.GenreName)
                {
                    selectedMovieGenre = item.Value;
                }
            }

            return selectedMovieGenre;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            MovieGenre genreToDiscount = GetMovieGenreByName();
            genreToDiscount.DiscountRate = Convert.ToDouble(txtDiscount.Text);
            txtDiscount.Text = string.Empty;
            txtOldDiscountRate.Text = genreToDiscount.DiscountRate.ToString();
        }

        private void GenreDiscount_Load(object sender, EventArgs e)
        {
            cmbGenres.DataSource = genreList.GetComponents().Values.ToList();
        }

        private void cmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieGenre genreDiscountRate = GetMovieGenreByName();
            txtOldDiscountRate.Text = genreDiscountRate.DiscountRate.ToString();
        }
    }


}
