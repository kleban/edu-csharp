using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = Guid.NewGuid().ToString();
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Author}, {Title} ({Year})";
        }

    }
}
