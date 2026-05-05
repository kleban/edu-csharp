using CsvHelper;
using CsvHelper.Configuration;
using DataReadWright.Services;
using OfficeOpenXml;
using System.Globalization;
using System.Text.Json;

namespace DataReadWright
{
    public partial class Form1 : Form
    {
        private IDataManager dataManager = null;
        public Form1()
        {
            InitializeComponent();
        }

        private List<Student> group = new List<Student>();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Group files (*.std)|*.std|All files (*.*)|*.*";
            dataManager = new StreamDataManager();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    group = dataManager.LoadData(dialog.FileName);
                    updateListBox();
                    MessageBox.Show($"Data loaded successfully. {group.Count} students found.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                catch(Exception ex)
                { 
                    MessageBox.Show($"Error loading data: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateListBox()
        {
            listBoxGroup.Items.Clear();
            listBoxGroup.Items.AddRange(group.ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Group files (*.std)|*.std|All files (*.*)|*.*";

            if(dataManager is not StreamDataManager)
                dataManager = new StreamDataManager();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataManager.SaveData(group, dialog.FileName);
                    MessageBox.Show($"Data saved successfully. {group.Count} students saved.",
                           "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            
            if(dataManager is not CsvDataManager)
                dataManager = new CsvDataManager();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                group = dataManager.LoadData(dialog.FileName);

                updateListBox();

                MessageBox.Show($"Data loaded successfully. {group.Count} students found.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveCsv_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dataManager is not CsvDataManager)
                dataManager = new CsvDataManager();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dataManager.SaveData(group, dialog.FileName);
                MessageBox.Show($"Data saved successfully. {group.Count} students saved.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonSaveJson_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(group);
                File.WriteAllText(dialog.FileName, json);
            }
        }
        private void buttonOpenJson_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.OpenText(dialog.FileName).ReadToEnd();
                group = JsonSerializer.Deserialize<List<Student>>(json);
                updateListBox();
            }
        }

        private void buttonSaveXlsx_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var students = listBoxGroup.Items.Cast<Student>().ToList();

                using (var package = new ExcelPackage(dialog.FileName))
                {
                    var sheet = package.Workbook.Worksheets.Add("Students");

                    sheet.Cells[1, 1].Value = "Name";
                    sheet.Cells[1, 2].Value = "Age";
                    sheet.Cells[1, 3].Value = "Grade";

                    int rowIndex = 1;
                    foreach (var student in students)
                    {
                        sheet.Cells[++rowIndex, 1].Value = student.Name;
                        sheet.Cells[rowIndex, 2].Value = student.Age;
                        sheet.Cells[rowIndex, 3].Value = student.Grade;
                    }

                    package.Save();
                }
            }

        }

        private void buttonOpenXlsx_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "EXCEL files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

          

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                group.Clear();

                using (var package = new ExcelPackage(dialog.FileName))
                {
                    var sheet = package.Workbook.Worksheets["Students"];

                    for (int i = 2; i < sheet.Rows.Count(); i++)
                    {
                        group.Add(new Student
                        {
                            Name = sheet.Cells[i, 1].Value.ToString(),
                            Age = int.Parse(sheet.Cells[i, 2].Value.ToString()),
                            Grade = double.Parse(sheet.Cells[i, 3].Value.ToString())
                        });
                    }

                    updateListBox();
                }
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var r = new Random();
            var student = new Student
            {
                Age = r.Next(18, 30),
                Grade = r.Next(50, 100),
                Name = $"Student {r.Next(1000, 10000)}"
            };
            group.Add(student);
            updateListBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxGroup.SelectedIndex != -1)
            {
                listBoxGroup.Items.RemoveAt(listBoxGroup.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
