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
    public partial class GenreList : Form
    {
        public GenreList()
        {
            InitializeComponent();
        }

        private void GenreList_Load(object sender, EventArgs e)
        {
            /*----get values from list to listBox----*/
            lstGenres.DataSource = MovieGenres.GetInstance().GetComponents().Values.ToList();
        }
    }
}
