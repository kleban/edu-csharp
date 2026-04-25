using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppUI.Exceptions
{
    public class CarFileFormatException : ApplicationException
    {
        public CarFileFormatException(string message, string file) 
            : base($"{message}: {file}")
        {
           
        }        
    }
}
