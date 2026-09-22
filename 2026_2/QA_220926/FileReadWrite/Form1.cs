using CsvHelper;
using FileReadWrite.Data;
using System.Globalization;
using System.Text.Json;

namespace FileReadWrite
{
    public partial class Form1 : Form
    {
        private List<PockemonItem> _items = new List<PockemonItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                readCsv(dialog.FileName);
                listBoxViewData.Items.AddRange(_items.ToArray());
            }
        }

        private void readCsv(string path)
        {
            try
            {
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    _items = csv.GetRecords<PockemonItem>().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                saveJSON(dialog.FileName);
                MessageBox.Show("Json Saved");
            }
        }

        void saveJSON(string path)
        {
            string json = JsonSerializer.Serialize(_items);
            StreamWriter writer = new StreamWriter(path);
            writer.Write(json);
            writer.Flush();
            writer.Close();
        }

        private void buttonOpenJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                readJSON(dialog.FileName);
                listBoxViewData.Items.Clear();
                listBoxViewData.Items.AddRange(_items.ToArray());
            }
        }

        void readJSON(string path)
        {
            string json = File.OpenText(path).ReadToEnd();
            _items = JsonSerializer.Deserialize<List<PockemonItem>>(json);
        }
    }
}
