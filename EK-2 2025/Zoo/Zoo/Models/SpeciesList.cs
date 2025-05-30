using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class SpeciesList
    {
        public List<string> Species { get; set; }
        public SpeciesList()
        {
            Species = new List<string>
            {
                "Lion",
                "Tiger",
                "Bear",
                "Elephant",
                "Giraffe",
                "Zebra",
                "Kangaroo",
                "Panda",
                "Penguin",
                "Flamingo"
            };
        }   
        
        public string GetRandomSpecies()
        {
            Random random = new Random();
            int index = random.Next(Species.Count);
            return Species[index];
        }
    }
}
