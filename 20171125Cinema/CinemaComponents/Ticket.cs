using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComponents
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public double TicketPrice { get; set; }
        public Movie ChosenMovie { get; set; }

        public override string ToString()
        {
            return TicketID+"-"+TicketPrice+"-"+ChosenMovie.ToString();
        }
    }
}
