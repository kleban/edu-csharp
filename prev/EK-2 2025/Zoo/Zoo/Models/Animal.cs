using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        
        public override string ToString()
        {
            return $"{Name} ({Species}), Age: {Age}";
        }
    }
}
