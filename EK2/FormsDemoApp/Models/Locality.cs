using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDemoApp.Models
{
    public class Locality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Info { get { return $"{Id}: {Name}"; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
