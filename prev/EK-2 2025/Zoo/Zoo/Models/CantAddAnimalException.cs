using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class CantAddAnimalException : ApplicationException
    {
        // Default constructor
        public CantAddAnimalException(string msg) : base(msg)
        {
        }
    }
}
