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
    public partial class ShowTickets : Form
    {
        string listType;
        public ShowTickets(string listType)
        {
            this.listType = listType;
            InitializeComponent();
        }

        private void ShowTickets_Load(object sender, EventArgs e)
        {
            if (listType == "Vizyondakiler")
            {
                lstTickets.Items.Add("Film Adı - Satılan Bilet Sayısı");
                foreach (KeyValuePair<Movie,int> item in Tickets.GetInstance().CountTickets())
                {
                    /*----Vizyondaki Filmler için Listeleme----*/
                    if (item.Key.Release.LastDayOfRelease.Date >= DateTime.Now.Date)
                    {
                        lstTickets.Items.Add(item.Key+" - "+item.Value);
                    }
                }
            }
            else
            {
                foreach (KeyValuePair<Movie, int> item in Tickets.GetInstance().CountTickets())
                {
                    /*----Tüm filmler için Listeleme----*/
                        lstTickets.Items.Add(item.Key + " - " + item.Value);
                }
            }

        }
    }
}
