using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalitiesApp.Classes
{
    public class Region
    {
        public string Name { get; set; }
        public Locality[] Localities { get; set; }
    }
}
