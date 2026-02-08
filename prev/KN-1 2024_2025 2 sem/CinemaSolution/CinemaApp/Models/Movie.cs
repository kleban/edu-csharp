using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } 
        public string AgeRating { get; set; }

        public override string ToString()
        {
            return $"{Title}, ({Genre}), {Duration} min, Age: {AgeRating}";
        }
    }
}
