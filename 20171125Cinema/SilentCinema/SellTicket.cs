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
    public partial class SellTicket : Form
    {
        public double TicketPrice { get; set; }
        public double WeekendTicketPrice { get; set; }
        Movies recordedMovies;
        List<Ticket> ticketsInOneSell = new List<Ticket>();

        public SellTicket()
        {
            InitializeComponent();
        }



        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            /*----Add Sold Ticket To Temp List And Open Another Ticket----*/
            Ticket tickettoTempList = new Ticket();
            tickettoTempList.TicketID = txtTicketID.Text;
            tickettoTempList.ChosenMovie = GetMovieByName();
            tickettoTempList.TicketPrice = Convert.ToDouble(txtTicketPrice.Text);
            ticketsInOneSell.Add(tickettoTempList);

            /*----Get New ID for new ticket----*/
            txtTicketID.Text = GetID();
            txtTicketPrice.Text = CalculatePrice(DateTime.Now).ToString();
        }

        private void SellTicket_Load(object sender, EventArgs e)
        {
            recordedMovies = Movies.GetInstance();
            cmbTicketMovie.DataSource = GetOnReleaseMovies();
            txtTicketPrice.Text = CalculatePrice(DateTime.Now).ToString();
            txtTicketID.Text = GetID();
        }


        private double CalculatePrice(DateTime sellingDate)
        {
            Movie selectedMovie = null;
            try
            {
                selectedMovie = GetMovieByName();
                if (sellingDate.DayOfWeek.ToString() == "Saturday" || sellingDate.DayOfWeek.ToString() == "Sunday")
                {
                    if (selectedMovie.DiscountRate + selectedMovie.Genre.DiscountRate > 100)
                    {
                        MessageBox.Show("Filmin fiyatı negatif değer olamaz indirim oranlarını kontrol ediniz.", "Fiyat hesaplama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    else
                    {
                        return WeekendTicketPrice - (WeekendTicketPrice * (selectedMovie.DiscountRate / 100.0)) - (WeekendTicketPrice * (selectedMovie.Genre.DiscountRate / 100.0));
                    }
                }
                else
                {
                    if (selectedMovie.DiscountRate + selectedMovie.Genre.DiscountRate > 100)
                    {
                        MessageBox.Show("Filmin fiyatı negatif değer olamaz indirim oranlarını kontrol ediniz.", "Fiyat hesaplama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    else
                    {
                        return TicketPrice - (TicketPrice * (selectedMovie.DiscountRate / 100.0)) - (TicketPrice * (selectedMovie.Genre.DiscountRate / 100.0));
                    }
                    
                }

            }
            catch (NullReferenceException nullException)
            {
                if (selectedMovie == null)
                {
                    MessageBox.Show("Lütfen Film Ekleyiniz.");
                }
                else
                {
                    MessageBox.Show(nullException.Message);
                }
                return 0;
            }

        }


        /*----Get the Movie object from selected name in combobox----*/
        private Movie GetMovieByName()
        {
            Movie selectedMovie = new Movie();
            foreach (KeyValuePair<string, Movie> item in recordedMovies.GetComponents())
            {
                if (cmbTicketMovie.SelectedValue.ToString() == item.Value.MovieName)
                {
                    selectedMovie = item.Value;
                }
            }

            return selectedMovie;
        }


        private string GetID()
        {
            Guid id = Guid.NewGuid();
            return id.ToString().Substring(0, 8).ToUpper();
        }

        private void cmbTicketMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTicketPrice.Text = CalculatePrice(dtpTicketDate.Value).ToString();
        }


        /*----Get movies which releases are not expired yet----*/
        private List<Movie> GetOnReleaseMovies()
        {
            List<Movie> moviesOnTheatre = new List<Movie>();
            foreach (Movie item in recordedMovies.GetComponents().Values)
            {
                if (item.Release.LastDayOfRelease.Date >= DateTime.Now.Date)
                {
                    moviesOnTheatre.Add(item);
                }
            }

            return moviesOnTheatre;
        }

        private void btnSubmitTickets_Click(object sender, EventArgs e)
        {
            DialogResult approveTickets = new DialogResult();
            approveTickets=MessageBox.Show(string.Format("{0} adet bileti onaylıyor musunuz?",ticketsInOneSell.Count),
                                             "Bilet Onayı",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (approveTickets == DialogResult.Yes)
            {
                SubmitTicketsToList();
                MessageBox.Show("Biletleriniz Hazırlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kaydetme İşlemi İptal Edildi.");
            }
        }


        private void SubmitTicketsToList()
        {
            Tickets addNewTickets = Tickets.GetInstance();
            foreach (Ticket item in ticketsInOneSell)
            {
                addNewTickets.AddComponent(item);
            }

            ticketsInOneSell.Clear();
        }

        private void btnCancelTickets_Click(object sender, EventArgs e)
        {
            DialogResult cancelTickets = new DialogResult();
            cancelTickets = MessageBox.Show(string.Format("{0} adet bilet işleme alındı,işleme alınan biletler kaydedilsin mi?", ticketsInOneSell.Count), 
                                            "Satın Alma İptali", 
                                            MessageBoxButtons.YesNoCancel, 
                                            MessageBoxIcon.Question);

            if (cancelTickets == DialogResult.Yes)
            {
                SubmitTicketsToList();
                this.Close();
            }
            else if(cancelTickets==DialogResult.No)
            {
                ticketsInOneSell.Clear();
                this.Close();
            }
        }

        private void changePrice()
        {

        }

    }
}


