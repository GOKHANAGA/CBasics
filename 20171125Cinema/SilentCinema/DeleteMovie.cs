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
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        Movies movieList = Movies.GetInstance();

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            cmbMovies.DataSource = movieList.GetComponents().Values.ToList();
        }


        /*----Get the Movie object from selected name in combobox----*/
        private Movie GetMovieByName()
        {
            Movie selectedMovie = new Movie();
            foreach (KeyValuePair<string, Movie> item in movieList.GetComponents())
            {
                if (cmbMovies.SelectedValue.ToString() == item.Value.MovieName)
                {
                    selectedMovie = item.Value;
                }
            }

            return selectedMovie;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Movie movieToDelete = new Movie();
            movieToDelete.MovieName = cmbMovies.SelectedValue.ToString();
            movieToDelete.MovieID = movieToDelete.MovieName + txtReleaseYear.Text;
            movieList.DeleteComponent(movieToDelete);
            txtReleaseYear.Text = string.Empty;
        }
    }
}
