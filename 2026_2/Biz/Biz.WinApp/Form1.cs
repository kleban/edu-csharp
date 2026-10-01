using Biz.Data.Models;
using Biz.Management;
using Biz.Management.Parser;

namespace Biz.WinApp
{
    public partial class FormApp : Form
    {
        private List<Business> _businesses = new List<Business>();
        private List<BusinessType> _types = new List<BusinessType>();
        private IDataManager _manager;

        public FormApp()
        {
            InitializeComponent();
            _manager = new CsvDataManager();
        }

        void updateBizListBox()
        {
            listBoxBizData.Items.Clear();
            listBoxBizData.Items.AddRange(_businesses.ToArray());
        }

        private void buttonOpenDataForParsing_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV |*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                (_businesses, _types) = DataParser.ParseData(dialog.FileName);
                updateBizListBox();
            }
        }

        private void buttonSaveToCSV_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "CSV |*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _manager.Write(dialog.FileName, _businesses);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            _businesses.Clear();
            updateBizListBox();
        }

        private void buttonFromCSV_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV |*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _businesses = _manager.Read(dialog.FileName);
                updateBizListBox();
            }
        }

        private void buttonJSON_Click(object sender, EventArgs e)
        {
            _manager = new JsonDataManager();

            var dialog = new SaveFileDialog();
            dialog.Filter = "JSON |*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _manager.Write(dialog.FileName, _businesses);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "JSON |*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _businesses = _manager.Read(dialog.FileName);
                updateBizListBox();
            }
        }
    }
}
