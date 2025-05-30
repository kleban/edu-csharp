using System.Windows.Forms;

namespace ReadWriteProductsDemo
{
    public partial class Form1 : Form
    {
        private IProductReaderWriter _readerWriter;
        private List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            _readerWriter = new ProductReaderWriter();
        }

        void updateList()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in _products)
                listBoxProducts.Items.Add(product);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MS Excel Files (*.xlsx)|*.xlsx|JSON Files (*.json)|*.json|Product Files|*.txt;|CSV Files (*.csv)|*.csv|All Files|*.*",
                Title = "Open Product File"
            };

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    var ext = fileInfo.Extension.ToLower().TrimStart('.');
                    switch(ext)
                    {
                        case "csv":
                            _readerWriter = new CsvProductReaderWriter();
                            break;
                        case "xlsx":
                            _readerWriter = new ExcelReaderWriter();
                            break;
                        case "txt":
                            _readerWriter = new ProductReaderWriter();
                            break;
                        case "json":
                            _readerWriter = new JsonReaderWriter();
                            break;
                        default:                            
                            break;
                    }
                    _products = _readerWriter.Read(openFileDialog.FileName);

                    updateList();
                } 
                catch(WrongProductFileException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var r = new Random();
            _products.Add(new Product
            {
                Name = "Product " + r.Next(1, 1000),
                Price = r.NextDouble() * 100,
                Quantity = r.Next(1, 100),
                Unit = "pcs"
            });
            updateList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "MS Excel Files (*.xlsx)|*.xlsx|JSON Files (*.json)|*.json|Product Files|*.txt;|CSV Files (*.csv)|*.csv|All Files|*.*",
                Title = "Save Product File"
            };

            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                var ext = fileInfo.Extension.ToLower().TrimStart('.');
                switch (ext)
                {
                    case "csv":
                        _readerWriter = new CsvProductReaderWriter();
                        break;
                    case "xlsx":
                        _readerWriter = new ExcelReaderWriter();
                        break;
                    case "txt":
                        _readerWriter = new ProductReaderWriter();
                        break;
                    case "json":
                        _readerWriter = new JsonReaderWriter();
                        break;
                    default:
                        break;
                }

                _readerWriter.Write(_products, saveFileDialog.FileName);
            }
        }
    }

}
