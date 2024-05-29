using VacancyApp.Exceptions;
using VacancyApp.Models;
using VacancyApp.Services;

namespace VacancyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Adv> _advs = new List<Adv>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void _updateList()
        {
            listBoxAds.Items.Clear();
            listBoxAds.Items.AddRange(_advs.ToArray());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "KN Special File (*.kn)|*.kn";

            if (DialogResult.OK == dialog.ShowDialog())
            {
                try
                {
                    _advs = AdvDataManager.Read(dialog.FileName);
                }
                catch (NegativeSalaryExeception nse) 
                {
                    MessageBox.Show(nse.Message);
                }
                catch
                {
                    MessageBox.Show("Unknown error!");
                }

                _updateList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var r = new Random();

            var new_adv = new Adv
            {
                Id = _advs.Count + 1,
                Name = ".NET Developer",
                Company = _advs.Count > 0 ? _advs[r.Next(0, _advs.Count)].Company : "Undefined",
                Salary = r.Next(7000, 50000) / 10.0
            };

            _advs.Add(new_adv);
            _updateList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "KN Special File (*.kn)|*.kn";

            if (DialogResult.OK == dialog.ShowDialog())
            {
                AdvDataManager.Save(dialog.FileName, _advs);
            }
        }
    }
}
