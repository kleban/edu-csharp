using CarAppUI.Exceptions;
using CarAppUI.Models;
using CarAppUI.Services;

namespace CarAppUI
{
    public partial class Form1 : Form
    {
        private string filePath = "database.cars";

        private List<Car> _cars = new List<Car>();

        private DataService _dataService = new DataService();

        private bool _isEdited = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _refreshList();
            _checkExistingFile();
        }

        private void _checkExistingFile()
        {
            if (File.Exists(filePath))
            {
                _cars = _dataService.Read(filePath);
                labelIFlePath.Text = filePath;
                _refreshList();
            }
        }

        void _refreshList()
        {
            listBoxCars.Items.Clear();
            listBoxCars.Items.AddRange(_cars.ToArray());
        }

        void updateStatus()
        {
            labelIFlePath.Text = filePath;
            labelEditedStatus.Text = "Статус: " + (_isEdited ? "Не збережено" : "Збережено");
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isEdited)
            {
                _dataService.Write(filePath, _cars);
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Car Database (*.cars)|*.cars|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                try
                {
                    _cars = _dataService.Read(filePath);
                    _isEdited = false;
                    updateStatus();
                    _refreshList();
                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Error reading file: " + ioex.Message, "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CarFileFormatException cex)
                {
                    MessageBox.Show("Error loading file: " + cex.Message, "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("An unexpected error occurred while loading the file.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Please enter the car model.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxMark.Text))
            {
                MessageBox.Show("Please enter the car mark.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxYear.Text))
            {
                MessageBox.Show("Please enter the car year.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var car = new Car
            {
                Model = textBoxModel.Text,
                Mark = textBoxMark.Text,
                Year = int.Parse(textBoxYear.Text),
                RegisterDate = dateTimePickerRegDate.Value,
                Price = (double)numericUpDownPrice.Value
            };

            _cars.Add(car);
            _isEdited = true;
            updateStatus();
            _refreshList();
        }



        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Car Database (*.cars)|*.cars|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                _dataService.Write(filePath, _cars);
                _isEdited = false;
                updateStatus();
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
