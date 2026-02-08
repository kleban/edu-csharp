using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;

namespace Zoo.Services
{
    public class AnimalService
    {
        private readonly string _filePath = "animals.txt";
        private List<Animal> animals;
        public AnimalService()
        {
            loadAnimals();
        }

        public List<Animal> GetAnimals()
        {
            if (animals == null)
            {
                loadAnimals();
            }
            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            if (animals == null)
            {
                loadAnimals();
            }
            animals.Add(animal);
            saveAnimals();
        }

        private void saveAnimals()
        {
            using (StreamWriter writer = new StreamWriter(_filePath, false))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.Name}, {animal.Species}, {animal.Age}");
                }
            }
        }

        private void loadAnimals()
        {
            animals = new List<Animal>();

            if (!File.Exists(_filePath))
            {
                return; // No animals to load
            }

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        var animal = new Animal
                        {
                            Name = parts[0].Trim(),
                            Species = parts[1].Trim(),
                            Age = int.Parse(parts[2].Trim())
                        };
                        animals.Add(animal);
                    }
                }
            }
        }
    }
}
