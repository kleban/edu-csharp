using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalitiesApp.Classes
{
    // має
    // є :
    public abstract class Locality
    {
        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
    }
}
