using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDemo.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;

        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        }
    }
}
