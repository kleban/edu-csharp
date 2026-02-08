using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    internal class RemoteAPIBookReader : IBookReader
    {
        public List<Book> ReadBooks()
        {
            return new List<Book> { new Book { Title = "T2" } };
        }
    }
}
