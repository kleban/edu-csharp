using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year}) - {Genre.Name}";
        }
    }
}
