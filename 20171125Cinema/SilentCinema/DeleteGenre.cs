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
    public partial class DeleteGenre : Form
    {
        MovieGenres genreList = MovieGenres.GetInstance();

        public DeleteGenre()
        {
            InitializeComponent();
        }

        private void DeleteGenre_Load(object sender, EventArgs e)
        {
            /*----Get values from list to combobox for choosing value to delete----*/
            cmbMovieGenres.DataSource = genreList.GetComponents().Keys.ToList();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            /*----Delete the chosen genre from combobox and refresh combobox----*/
            MovieGenre genreToDelete;
            genreList.GetComponents().TryGetValue(cmbMovieGenres.SelectedValue.ToString(), out genreToDelete);
            genreList.DeleteComponent(genreToDelete);
            cmbMovieGenres.DataSource = null;
            cmbMovieGenres.DataSource = genreList.GetComponents().Keys.ToList();
        }
    }
}
