using Zoo.Models;
using Zoo.Services;

namespace Zoo
{
    public partial class Form1 : Form
    {
        private readonly AnimalService _animalService = new AnimalService();
        private readonly AviaryService _aviaryService;
        public Form1()
        {
            InitializeComponent();
            _aviaryService = new AviaryService(_animalService);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAnimalList();
        }

        void updateAnimalList()
        {
            listBoxAnimals.Items.Clear();
            var animals = _animalService.GetAnimals();
            foreach (var animal in animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            _animalService.AddAnimal(new Animal
            {
                Name = "Animal_" + new Random().Next(1000, 10000),
                Species = new SpeciesList().GetRandomSpecies(),
                Age = new Random().Next(1, 20)
            });
            updateAnimalList();
        }

        private void buttonSaveAnimals_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
