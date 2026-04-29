using CsvHelper;
using CsvHelper.Configuration;
using OfficeOpenXml;
using System.Globalization;
using System.Text.Json;

namespace DataReadWright
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Group files (*.std)|*.std|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(dialog.FileName);

                    string line = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        var std = new Student
                        {
                            Name = parts[0].Trim(),
                            Age = int.Parse(parts[1].Trim()),
                            Grade = double.Parse(parts[2].Trim())
                        };
                        listBoxGroup.Items.Add(std);
                    }
                }
                catch
                {
                    MessageBox.Show("Error reading file!");

                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Group files (*.std)|*.std|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(dialog.FileName);
                    foreach (Student std in listBoxGroup.Items)
                    {
                        string line = $"{std.Name}, {std.Age}, {std.Grade}";
                        writer.WriteLine(line);
                    }

                    MessageBox.Show("File Saved");
                }
                catch
                {
                    MessageBox.Show("Error writing file!");
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    TrimOptions = TrimOptions.Trim,
                    IgnoreBlankLines = true
                };

                using (var reader = new StreamReader(dialog.FileName))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<Student>().ToList();
                    listBoxGroup.Items.AddRange(records.ToArray());
                }

            }
        }

        private void buttonSaveCsv_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                using (var writer = new StreamWriter(dialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listBoxGroup.Items.Cast<Student>().ToList());
                }
            }

        }

        private void buttonSaveJson_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(listBoxGroup.Items);
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
                var list = JsonSerializer.Deserialize<List<Student>>(json);
                listBoxGroup.Items.AddRange(list.ToArray());
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
                using (var package = new ExcelPackage(dialog.FileName))
                {
                    var sheet = package.Workbook.Worksheets["Students"];

                    for (int i = 2; i < sheet.Rows.Count(); i++)
                    {
                        listBoxGroup.Items.Add(new Student
                        {
                            Name = sheet.Cells[i, 1].Value.ToString(),
                            Age = int.Parse(sheet.Cells[i, 2].Value.ToString()),
                            Grade = double.Parse(sheet.Cells[i, 3].Value.ToString())
                        });
                    }

                }
            }
        }
    }
}
