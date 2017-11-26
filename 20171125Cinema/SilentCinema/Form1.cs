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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double ticketPrice=10;
        public static double weekendTicketPrice = 15;


        /*----Bilet Satışı----*/
        private void yeniBiletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Movies.GetInstance().GetComponents().Count == 0)
            {
                MessageBox.Show("Lütfen en az bir film ekleyiniz.",
                                "Film Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                SellTicket newTicket = new SellTicket();
                newTicket.MdiParent = this;
                newTicket.TicketPrice = ticketPrice;
                newTicket.WeekendTicketPrice = weekendTicketPrice;
                newTicket.Show();
            }

        }


        /*----Listeye Eklemeler----*/
        private void türEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovieGenre newGenre = new AddMovieGenre();
            newGenre.MdiParent = this;
            newGenre.Show();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MovieGenres.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film türü ekleyiniz.",
                                "Film Türü Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                AddMovie newMovie = new AddMovie();
                newMovie.MdiParent = this;
                newMovie.Show();
            }

        }


        /*----Eleman Silmeler----*/
        private void filmKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Movies.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film ekleyiniz.",
                                "Film Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DeleteMovie deleteMovie = new DeleteMovie();
                deleteMovie.MdiParent = this;
                deleteMovie.Show();
            }

        }

        private void türKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MovieGenres.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film türü ekleyiniz.",
                                "Film Türü Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DeleteGenre deleteGenre = new DeleteGenre();
                deleteGenre.MdiParent = this;
                deleteGenre.Show();
            }

        }

        private void biletİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tickets.GetInstance().IsEmpty())
            {
                MessageBox.Show("Kayıtlı bilet bulunmamaktadır.Lütfen önce bilet satışını yapınız.",
                                "Kayıtlı Bilet Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DeleteTicket deleteTicket = new DeleteTicket();
                deleteTicket.MdiParent = this;
                deleteTicket.Show();
            }

        }


        /*----Listeleme İşlemleri----*/
        private void vizyondakiFilmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Movies.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film ekleyiniz.",
                                "Film Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MoviesOnRelease showNewMovies = new MoviesOnRelease("Vizyondakiler");
                showNewMovies.MdiParent = this;
                showNewMovies.Show();
            }

        }

        private void tümFilmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Movies.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film ekleyiniz.",
                                "Film Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MoviesOnRelease showNewMovies = new MoviesOnRelease("Tüm Filmler");
                showNewMovies.MdiParent = this;
                showNewMovies.Show();
            }

        }

        private void filmTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MovieGenres.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film türü ekleyiniz.",
                                "Film Türü Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                GenreList showGenres = new GenreList();
                showGenres.MdiParent = this;
                showGenres.Show();
            }

        }

        private void vizyondakilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tickets.GetInstance().IsEmpty())
            {
                MessageBox.Show("Kayıtlı bilet bulunmamaktadır.Lütfen önce bilet satışını yapınız.",
                                "Kayıtlı Bilet Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                /*----Vizyondaki Filmlerin Bilet Satışları----*/
                ShowTickets listSoldTickets = new ShowTickets("Vizyondakiler");
                listSoldTickets.MdiParent = this;
                listSoldTickets.Show();
            }
        }

        private void vizyonTarihiDolanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tickets.GetInstance().IsEmpty())
            {
                MessageBox.Show("Kayıtlı bilet bulunmamaktadır.Lütfen önce bilet satışını yapınız.",
                                "Kayıtlı Bilet Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                ShowTickets listSoldTickets = new ShowTickets("Tüm Biletler");
                listSoldTickets.MdiParent = this;
                listSoldTickets.Show();
            }

        }


        /*----İndirim İşlemleri----*/
        private void indirimTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Movies.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film ekleyiniz.",
                                "Film Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MovieDiscount addDiscount = new MovieDiscount();
                addDiscount.MdiParent = this;
                addDiscount.Show();
            }

        }


        private void indirimTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MovieGenres.GetInstance().IsEmpty())
            {
                MessageBox.Show("Lütfen en az bir film türü ekleyiniz.",
                                "Film Türü Bulunamadı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                GenreDiscount addDiscount = new GenreDiscount();
                addDiscount.MdiParent = this;
                addDiscount.Show();
            }

        }


    }
}
