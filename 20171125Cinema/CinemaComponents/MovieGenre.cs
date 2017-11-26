using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaComponents
{
    public class MovieGenre : IDiscountable
    {

        public string GenreName { get; set; }
        public double DiscountRate { get; set; }

        public override string ToString()
        {
            return GenreName;
        }
    }
}
