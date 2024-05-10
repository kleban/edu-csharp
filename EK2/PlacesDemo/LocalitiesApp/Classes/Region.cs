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
        public Locality[] Localities { get; set; } = new Locality[0];

        public override string ToString()
        {
            return $"{Name}, Localities: {Localities.Length}";
        }
    }
}
