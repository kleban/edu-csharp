using FrbsApp.Core.Models;
using FrbsApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FrbsApp.UI
{
    public partial class MainWindow : Form
    {
        private readonly IRepository<Country> _countryRepo = null;
        private readonly IRepository<City> _cityRepo = null;
        private readonly IRepository<Category> _categoryRepo = null;
        private readonly IPersonRepository _personRepo = null;
        public MainWindow()
        {
            InitializeComponent();

            var context = new FrbsApp.Core.Context.FrbsContext();
            _countryRepo = new Repository<Country>(context);
            _cityRepo = new Repository<City>(context);
            _categoryRepo = new Repository<Category>(context);
            _personRepo = new PersonRepository(context);
        }

        void updateCountries()
        {
            listBoxCountries.Items.Clear();
            listBoxCountries.Items.AddRange(_countryRepo.GetAll().ToArray());
            comboBoxCountry.Items.Clear();
            comboBoxCountry.Items.AddRange(_countryRepo.GetAll().ToArray());
            comboBoxCountry.SelectedIndex = 0;
        }

        void updateCategories()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(_categoryRepo.GetAll().ToArray());
            comboBoxCategory.SelectedIndex = 0;
        }
        void updateCities()
        {
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.AddRange(_cityRepo.GetAll().ToArray());
            comboBoxCity.SelectedIndex = 0;
        }

        void updatePeople()
        {
            listBoxPeople.Items.Clear();
            listBoxPeople.Items.AddRange(_personRepo.GetAll()
                .OrderBy(x => x.Rank)
                .ToArray());
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            updateCountries();
            updatePeople();
            updateCategories();            
        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedIndex != -1)
            {
                var person = (Person)listBoxPeople.SelectedItem;

                var dialog = MessageBox.Show($"Are you sure you want to delete {person.Name}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    _personRepo.Delete(person.Id);
                    updatePeople();
                }
            }
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCountry.SelectedIndex != -1)
            {
                updateCities();
            }
        }
    }
}
