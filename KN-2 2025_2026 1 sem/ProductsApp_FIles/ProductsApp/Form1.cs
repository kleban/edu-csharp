using Manager;

namespace ProductsApp
{
    public partial class Form1 : Form
    {
        private IProductManager _m = new ProductTextManager();

        string path = @"E:\\edu-csharp\\KN-2 2025_2026 1 sem\\ProductsApp_FIles\\ProductsApp\\products.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var products = _m.Read(path);
            listBox1.Items.AddRange(products.ToArray());
        }
    }
}
