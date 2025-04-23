using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppDemo.Models
{
    public class Library
    {
        private List<Book> books = new();
        public Library()
        {
            generateBooks();
        }

        public Book[] GetBooks()
        {
            return books.ToArray();
        }

        public void Add(Book book)
        {
            if (books.Any(b => b.ISBN == book.ISBN))
                throw new Exception("Book with this ISBN already exists.");
            books.Add(book);
        }

        public void Remove(string ISBN)
        {
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == ISBN);
            if (bookToRemove != null)
                books.Remove(bookToRemove);
        }

        private void generateBooks()
        {
            books.Add(new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Year = 1925,
                ISBN = "9780743273565"
            });
            books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, ISBN = "9780061120084" });
            books.Add(new Book { Title = "1984", Author = "George Orwell", Year = 1949, ISBN = "9780451524935" });
            books.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, ISBN = "9780141439518" });
            books.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, ISBN = "9780316769488" });
        }
    }
}
