using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbes.DataParser
{
    public class CsvPerson
    {        
        public int rank { get; set; }
        public string personName { get; set; }
        public int? age { get; set; }
        public int finalWorth { get; set; }
        public string category { get; set; }
        public string country { get; set; }
    }
}
