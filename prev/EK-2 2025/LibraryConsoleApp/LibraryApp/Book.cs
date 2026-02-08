using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"#{ISBN} - {Title}, {Author} ({Year})";
        }
    }
}
