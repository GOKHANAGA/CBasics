using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComponents
{
    public class Movie:IDiscountable
    {
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public MovieGenre Genre =new MovieGenre();
        public double DiscountRate { get; set; }
        public TheatricalRelease Release = new TheatricalRelease();

        public override string ToString()
        {
            return MovieName;
        }
    }
}
