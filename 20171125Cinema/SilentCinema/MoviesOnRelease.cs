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
    public partial class MoviesOnRelease : Form
    {

        Movies movieList = Movies.GetInstance();
        string listType;
        public MoviesOnRelease(string listType)
        {
            InitializeComponent();
            this.listType = listType;
        }


        private void MoviesOnRelease_Load(object sender, EventArgs e)
        {
            if (listType == "Vizyondakiler")
            {
                foreach (Movie item in movieList.GetComponents().Values)
                {
                    if (item.Release.LastDayOfRelease.Date >= DateTime.Now.Date)
                    {
                        lstMovies.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (Movie item in movieList.GetComponents().Values)
                {
                    lstMovies.Items.Add(item);

                }
            }


        }
    }
}
