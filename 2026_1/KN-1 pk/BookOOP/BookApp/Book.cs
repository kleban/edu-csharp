using System;
using System.Collections.Generic;
using System.Text;

namespace BookApp
{
    public class Book
    {
        private string title;
        private string author;
        private int pages = 1;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            Pages = pages;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Pages
        {
            get { return pages; }
            set 
            { 
                if(value >= 1)
                    pages = value; 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Pages: {pages}");
        }

        public bool IsLongBook()
        {
            return pages > 300;
        }
    }
}
