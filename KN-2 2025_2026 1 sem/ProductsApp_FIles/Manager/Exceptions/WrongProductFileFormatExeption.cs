using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Exceptions
{
    public class WrongProductFileFormatException : ApplicationException
    {
        public WrongProductFileFormatException(string msg, Exception ex) : base(msg, ex)
        {
            
        }


    }
}
