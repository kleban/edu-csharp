using Data;
using Manager;
using Manager.Exceptions;
using System.Globalization;

namespace ProductsApp
{
    public partial class Form1 : Form
    {
        private IProductManager _m = new ProductCsvManager();
        private List<Product> products = new List<Product>();

        string path = "";
        public Form1()
        {
            InitializeComponent();
            listBox1.Dock = DockStyle.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void loadData(string dataPath)
        {
            try
            {
                products = _m.Read(dataPath);
                updateProductsList();
            }
            catch (WrongProductFileFormatException wpe)
            {
                MessageBox.Show($"{wpe.Message}: {wpe.InnerException.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void updateProductsList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(products.ToArray());
        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var r = new Random();
            var randProduct = products[r.Next(products.Count)];
            var prod = new Product
            {
                Id = products.Max(x => x.Id) + 1,
                Name = randProduct.Name,
                Category = randProduct.Category,
                Price = Math.Round(randProduct.Price + r.Next(-10, 10), 2),
                Quantity = Math.Round(randProduct.Quantity + r.Next(-5, 5), 2)
            };

            products.Add(prod);
            updateProductsList();
            _m.Write(path, products);
            MessageBox.Show("Data saved!");
        }

        private void Ù‡ÈÎToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ÚÂÍÒÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = $"Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = toolStripStatusLabelPath.Text = dialog.FileName;
                string extension = Path.GetExtension(path).ToLower().TrimStart('.');

                setManager(extension);

                loadData(path);
                
                MessageBox.Show($"File loaded: {extension.ToUpper()}");
            }
        }

        private void ÚÂÍÒÚToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var extension = (sender as ToolStripMenuItem).Tag.ToString();

            var dialog = new SaveFileDialog();
            dialog.Filter = $"{char.ToUpper(extension[0]) + extension.Substring(1).ToLower()} files (*.{extension})|*.{extension}";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = toolStripStatusLabelPath.Text = dialog.FileName;
                setManager(extension);
                _m.Write(path, products);

                 MessageBox.Show($"File saved: {extension.ToUpper()}");
            }
        }

        private void setManager(string extension)
        {
            switch (extension)
            {
                case "txt":
                    _m = new ProductTextManager();
                    break;
                case "csv":
                    _m = new ProductCsvManager();
                    break;
            }
        }

       
    }
}
