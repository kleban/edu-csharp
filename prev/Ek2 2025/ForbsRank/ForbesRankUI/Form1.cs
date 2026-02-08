using ForbesRank.Domain.Context;
using ForbesRank.Domain.Models;
using ForbesRank.Repos;

namespace ForbesRankUI
{
    public partial class Form1 : Form
    {
        ICategoryRepository categoryRepository;
        IPersonRepository personRepository;
        ICountryRepository countryRepository;
        public Form1()
        {
            InitializeComponent();
            var ctx = new ForbesContext();
            categoryRepository = new CategoryRepository(ctx);
            personRepository = new PersonRepository(ctx);
            countryRepository = new CountryRepository(ctx);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCategoriesList();
            updatePersonList();
            updateCountriesList();
        }



        void updatePersonList()
        {
            listBoxPersons.Items.Clear();
            var persons = personRepository.GetAll();
            foreach (var person in persons.OrderBy(x => x.Rank))
            {
                listBoxPersons.Items.Add(person);
            }
        }

        void updateCountriesList()
        {
            //listBoxCategories.Items.Clear();
            comboBoxCountry.Items.Clear();

            var countries = countryRepository.GetAll();
            foreach (var category in countries)
            {
                // listBoxCategories.Items.Add(category);
                comboBoxCountry.Items.Add(category);
            }

            comboBoxCountry.SelectedIndex = 0;
        }

        void updateCategoriesList()
        {
            listBoxCategories.Items.Clear();
            comboBoxCategory.Items.Clear();

            var categories = categoryRepository.GetAll();
            foreach (var category in categories)
            {
                listBoxCategories.Items.Add(category);
                comboBoxCategory.Items.Add(category);
            }

            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            var selectedPerson = listBoxPersons.SelectedItem as Person;
            if (selectedPerson is null)
            {
                MessageBox.Show("Please select a person to delete.");
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete {selectedPerson.Name}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                personRepository.Delete(selectedPerson.Id);
                updatePersonList();
                MessageBox.Show("Person deleted successfully.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //check!!!!

            var person = new Person
            {
                Name = textBoxName.Text,
                Age = (int)numericUpDownAge.Value,
                FinalWorth = (double)numericUpDownWorth.Value,
                CategoryId = (comboBoxCategory.SelectedItem as Category).Id,
                CountryId = (comboBoxCountry.SelectedItem as Country).Id
            };
            personRepository.Create(person);
            updatePersonList();

            MessageBox.Show("Person saved successfully.");

        }

        private void buttonReRank_Click(object sender, EventArgs e)
        {
            personRepository.ReRank();
            updatePersonList();
        }
    }
}
