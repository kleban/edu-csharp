using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class LibraryManager
    {
        private List<Book> books;
        private List<Genre> genres;

        public LibraryManager()
        {
            books = new List<Book>();
            genres = new List<Genre>();
            generateGenres();
            generateBooks();
        }

        private void generateGenres()
        {
            genres.Add(new Genre { Name = "Fiction" });
            genres.Add(new Genre { Name = "Non-Fiction" });
            genres.Add(new Genre { Name = "Science Fiction" });
            genres.Add(new Genre { Name = "Fantasy" });
            genres.Add(new Genre { Name = "Mystery" });
            genres.Add(new Genre { Name = "Biography" });
        }

        public List<Book> Search(string title)
        {
            return books.Where(b => b.Title.Trim().ToLower()
                .Contains(title.Trim().ToLower())).ToList();
        }

        private void generateBooks()
        {
            books.Add(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = genres[0], ISBN = "9780743273565", Year = 1925 });
            books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = genres[0], ISBN = "9780061120084", Year = 1960 });
            books.Add(new Book { Title = "1984", Author = "George Orwell", Genre = genres[2], ISBN = "9780451524935", Year = 1949 });
            books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = genres[3], ISBN = "9780547928227", Year = 1937 });
            books.Add(new Book { Title = "The Da Vinci Code", Author = "Dan Brown", Genre = genres[4], ISBN = "9780307474278", Year = 2003 });
        }

        public bool CheckBooksInGenre(Genre genre)
        {
            return books.Any(b => b.Genre.Name.Trim().ToLower() == genre.Name.Trim().ToLower());
        }

        public void AddGenre(Genre genre)
        {
            genres.Add(genre);
        }

        public bool IsGenreExists(string genreName)
        {
            return genres.Any(g => g.Name.Trim().ToLower() == genreName.Trim().ToLower());
        }

        public void RemoveGenre(Genre genre)
        {
            genres.Remove(genre);
        }
        public void AddBook(Book book)
        {
            book.ISBN = new Random().Next(1000000000, int.MaxValue).ToString();
            books.Add(book);
        }
        public List<Book> GetBooks()
        {
            return books;
        }

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void RemoveBook(string isbn)
        {
            books.Remove(books.First(x => x.ISBN == isbn));
        }

        public void UpdateBook(Book editedBook)
        {
            var book = books.FirstOrDefault(b => b.ISBN == editedBook.ISBN);
            if (book != null)
            {
                book.Title = editedBook.Title;
                book.Author = editedBook.Author;
                book.Year = editedBook.Year;
                book.Genre = editedBook.Genre;
            }
        }
    }
}