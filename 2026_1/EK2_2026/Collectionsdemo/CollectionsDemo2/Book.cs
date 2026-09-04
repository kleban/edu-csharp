using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo2
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Author}. {Name} - ({Year}), {Pages} pages";
        }
    }
}
