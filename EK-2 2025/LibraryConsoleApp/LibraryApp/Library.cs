using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
            generateBooks();
        }

        private void generateBooks()
        {
            books.Add(new Book { Title = "1984", Author = "George Orwell", ISBN = "1234567890", Year = 1949 });
            books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", ISBN = "0987654321", Year = 1960 });
            books.Add(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "1122334455", Year = 1925 });
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public bool RemoveBook(string isbn)
        {
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                return true;
            }
            return false;
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
