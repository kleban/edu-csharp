using DataReadWrite.Domain;

namespace DataReadWrite.DataGenerator
{
    public class Library
    {
        private static List<Book> _books = new();
        public static IEnumerable<Book> Generate(int count = 5)
        {
            var r = new Random();

            var pubs = new List<Publisher>() { 
                new Publisher { Name = "Ababagalamaga", City = "Kyiv" },
                new Publisher { Name = "Ivan Fedorov Prints", City = "Ostroh" },
            };

            for(int i = 0; i < count; i++)
            {
                _books.Add(new Book
                {
                    Id = i + 1,
                    Title = $"Title {i+1}",
                    Year = r.Next(1900, DateTime.Now.Year),
                    Publisher = pubs[r.Next(0, pubs.Count)]
                });
            }

            return _books;
        }

    }
}
