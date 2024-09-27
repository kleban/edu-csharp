using DataReadWrite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataReadWrite.Managers
{
    public class JsonReaderWriter : IBookReaderWriter
    {
        public IEnumerable<Book> Read(string path)
        {
            string json = File.OpenText(path).ReadToEnd();
            var books = JsonSerializer.Deserialize<IEnumerable<Book>>(json);
            return books;
        }

        public void Write(IEnumerable<Book> books, string path)
        {
            string json = JsonSerializer.Serialize(books);
            File.WriteAllText(path, json);

        }
    }
}
