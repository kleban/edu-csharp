using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class LibraryManager
    {
        private List<Book> books;
        public LibraryManager()
        {
            books = new List<Book>();
            generateInitialBooks();
        }

        void generateInitialBooks()
        {
            books.Add(new Book("Book1", "Author1", 2000));
            books.Add(new Book("Book2", "Author2", 2001));
            books.Add(new Book("Book3", "Author3", 2002));
        }

        public void DeleteBook(string id)
        {
            books.RemoveAll(b => b.ISBN == id);
        }

        public void AddBook(string title, string author, int year)
        {
            books.Add(new Book(title, author, year));
        }

        public List<Book> GetBooks()
        {
            return books;
        }   
    }
}
