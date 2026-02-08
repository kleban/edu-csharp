using CsvHelper;
using CsvHelper.Configuration;
using DataReadWrite.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataReadWrite.Managers
{
    public class CsvReaderWriter : IBookReaderWriter
    {
        CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture) { 
            Delimiter = ";", 
            Encoding = Encoding.UTF8,
        HasHeaderRecord = false};

        public IEnumerable<Book> Read(string path)
        {
            IEnumerable<BookWithPublisher> books = null;

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                books = csv.GetRecords<BookWithPublisher>().ToList();
            }
            return books.Select(x => new Book 
            { 
                Id = x.Id,
                Publisher = new Publisher { City = x.PubCity, Name = x.PubName},
                Title = x.Title,
                Year = x.Year
            });
        }

        public void Write(IEnumerable<Book> books, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(books);
            }
        }
    }
}
