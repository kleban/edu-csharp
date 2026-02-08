using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zoo.Models;

namespace Zoo.Services
{
    public class AviaryService
    {
        private readonly string _filePath = "aviaries.txt";
        private List<Aviary> aviaries;
        private readonly AnimalService animalService;
        public AviaryService(AnimalService animalService)
        {
            loadAviaries();
            this.animalService = animalService;
        }

        public List<Aviary> GetAviaries()
        {
            if (aviaries == null)
            {
                loadAviaries();
            }
            return aviaries;
        }
        public void AddAnimal(Aviary aviary, Animal animal)
        {
            var av = aviaries.FirstOrDefault(a => a.Name == aviary.Name);
            av = new Aviary(aviary.Name);
            av.AddAnimal(animal);
        }
        public void AddAviary(Aviary a)
        {
            if (a == null)
            {
                loadAviaries();
            }
            aviaries.Add(a);
            saveAviaries();
        }

        private void saveAviaries()
        {
            using (StreamWriter writer = new StreamWriter(_filePath, false))
            {
                foreach (var av in aviaries)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"{av.Name},");
                    sb.Append(string.Join(";", av.Animals.Select(animal => animal.Name)));
                    writer.WriteLine(sb.ToString());
                }
            }
        }

        private void loadAviaries()
        {
            aviaries = new List<Aviary>();

            if (!File.Exists(_filePath))
            {
                return; // No aviaries to load
            }

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        var aviary = new Aviary
                        {
                            Name = parts[0].Trim(),
                            Animals = new List<Animal>()
                        };
                        foreach (var animalName in parts[1].Split(';'))
                        {
                            var animal = animalService.GetAnimals().FirstOrDefault(a => a.Name == animalName.Trim());
                            if (animal != null)
                                aviary.Animals.Add(animal);
                        }
                        aviaries.Add(aviary);
                    }
                }
            }
        }
    }
}
