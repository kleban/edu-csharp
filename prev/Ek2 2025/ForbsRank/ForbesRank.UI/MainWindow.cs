using ForbesRank.Repositories;

namespace ForbesRank.UI
{
    public partial class MainWindow : Form
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        private readonly ICountryRepository _countryRepository = new CountryRepository();
        private readonly IPersonRepository _personRepository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            updateCategories();
            updateCountries();
            updatePersons();
        }

        private void updatePersons()
        {
            listBoxPersons.Items.Clear();
            listBoxPersons.Items.AddRange(_personRepository.GetAll().ToArray());
        }

        private void updateCountries()
        {
            listBoxCountries.Items.Clear();
            listBoxCountries.Items.AddRange(_countryRepository.GetAll().ToArray());
        }

        private void updateCategories()
        {
            listBoxCategories.Items.Clear();
            listBoxCategories.Items.AddRange(_categoryRepository.GetAll().ToArray());
        }
    }
}
