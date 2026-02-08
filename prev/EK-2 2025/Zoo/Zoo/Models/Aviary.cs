using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class Aviary
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
        public Aviary(string name)
        {
            Name = name;
            Animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            if (Animals.Count > 0)
            {
                if (animal.Species.ToLower() == Animals[0].Species.ToLower())
                    Animals.Add(animal);
                else
                    throw new CantAddAnimalException($"Cannot add {animal.Species} to {Name}, it already contains {Animals[0].Species}.");
            }
            else
            {
                Animals.Add(animal);
            }
        }
        public override string ToString()
        {
            return $"{Name} - {Animals.Count} animals";
        }
    }
}
