using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComponents
{
    public class Tickets:DictionaryOperations<Ticket>
    {
        private Dictionary<string, Ticket> ticketList;
        private static Tickets _soldTickets;

        private Tickets()
        {
            ticketList = new Dictionary<string, Ticket>();
        }

        public static Tickets GetInstance()
        {
            if (_soldTickets == null)
            {
                _soldTickets = new Tickets();
            }

            return _soldTickets;
        }

        public override void AddComponent(Ticket componentType)
        {

            ticketList.Add(componentType.TicketID, componentType);

        }

        public override void DeleteComponent(Ticket componentType)
        {
            ticketList.Remove(componentType.TicketID);
        }

        public override Dictionary<string, Ticket> GetComponents()
        {
            return ticketList;
        }

        public Dictionary<Movie,int> CountTickets()
        {
            Dictionary<Movie, int> movieCount = new Dictionary<Movie, int>();
            foreach (Ticket item in ticketList.Values)
            {
                if(movieCount.ContainsKey(item.ChosenMovie)){
                    movieCount[item.ChosenMovie]++;
                }
                else
                {
                    movieCount.Add(item.ChosenMovie, 1);
                }
            }

            return movieCount;
        }

        public override bool IsEmpty()
        {
            if (ticketList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
