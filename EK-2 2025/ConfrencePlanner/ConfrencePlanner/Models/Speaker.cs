using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrencePlanner.Models
{
    public class Speaker
    {
        public string FullName { get; set; }
        public string Org { get; set; }
        public string Email { get; set; }
        
        public Position? Position { get; set; }
    }
}
