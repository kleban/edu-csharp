using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    public class WrongProductFileException : ApplicationException
    {
        public WrongProductFileException(string file_name) : base($"The product file is not in the correct format: {file_name}")
        {
        }
    }
}
