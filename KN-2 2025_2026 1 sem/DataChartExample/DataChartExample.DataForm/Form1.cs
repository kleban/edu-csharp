using DataChartExample.Infrastructure;
using DataChartExample.Domain;

namespace DataChartExample.DataForm
{
    public partial class Form1 : Form
    {
        string path = "E:\\edu-csharp\\KN-2 2025_2026 1 sem\\DataChartExample\\DataChartExample.DataForm\\bin\\Debug\\net8.0-windows\\data\\coffe.csv";//Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "coffee.csv");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelName.Text = path;
            Clipboard.SetText(path);
            _dg.DataSource = CoffeDataReader.Read(path);
        }

        private void chart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Chart1Form((List<CoffeDataItem>)_dg.DataSource);
            frm.ShowDialog(this);
        }

        private void chart2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Chart2Form((List<CoffeDataItem>)_dg.DataSource);
            frm.ShowDialog(this);
        }
    }
}
