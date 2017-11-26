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
    public partial class MovieDiscount : Form
    {
        Movies movieList = Movies.GetInstance();
        public MovieDiscount()
        {
            InitializeComponent();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            Movie myMovie = GetMovieByName();
            myMovie.DiscountRate = Convert.ToDouble(txtDiscount.Text);
            txtDiscount.Text = string.Empty;
            txtOldDiscount.Text = myMovie.DiscountRate.ToString();
        }

        private void MovieDiscount_Load(object sender, EventArgs e)
        {
            cmbMovie.DataSource = movieList.GetComponents().Values.ToList();
        }



        /*----Get the MovieGenre object from selected name in combobox----*/
        private Movie GetMovieByName()
        {
            Movie selectedMovie = new Movie();
            foreach (Movie item in movieList.GetComponents().Values)
            {
                if (cmbMovie.SelectedValue.ToString() == item.MovieName)
                {
                    selectedMovie = item;
                }
            }

            return selectedMovie;
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie selectedMovie = GetMovieByName();
            txtOldDiscount.Text = selectedMovie.DiscountRate.ToString();
        }
    }
}
