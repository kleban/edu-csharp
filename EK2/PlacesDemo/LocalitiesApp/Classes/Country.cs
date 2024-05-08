using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalitiesApp.Classes
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string CountryCode { get; set; }
        public Region[] Regions { get; set; }
    }
}
