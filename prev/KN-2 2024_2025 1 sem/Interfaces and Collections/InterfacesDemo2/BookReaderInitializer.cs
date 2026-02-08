using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    internal class BookReaderInitializer
    {
        private IBookReader _bookReader;
        public BookReaderInitializer(IBookReader reader) 
        { 
            _bookReader = reader;
        }

        public IBookReader Reader { get { return _bookReader; } }
    }
}
