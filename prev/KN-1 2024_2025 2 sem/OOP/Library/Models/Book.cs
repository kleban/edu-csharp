using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book : PrintedEntity
    {       
        public Author[] Authors { get; set; }
    
        public int Year { get; set; }
    }
}
