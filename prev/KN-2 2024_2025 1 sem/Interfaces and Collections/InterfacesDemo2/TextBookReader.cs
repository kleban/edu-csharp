using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    public class TextBookReader : IBookReader
    {
        List<Book> IBookReader.ReadBooks()
        {
            return new List<Book>() { new Book { Author = "A1", Title = "T1" } };
        }
    }
}
