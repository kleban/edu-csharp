namespace DataGridViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateProducts();
        }

        List<Product> products = new List<Product>();
        void generateProducts()
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product
                {
                    Name = $"Product {i + 1}",
                    Price = (decimal)(r.NextDouble() * 100),
                    Quantity = r.Next(1, 20)
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_dg.DataSource = products;

            _dg.Columns.Add("Name", "Назва товару");
            _dg.Columns.Add("Price", "Ціна, грн");
            _dg.Columns.Add("Quantity", "Кількість");
            _dg.Columns.Add("Total_Amount", "Загальна варість, грн");

            foreach (Product p in products)
            {
                _dg.Rows.Add(p.Name, Math.Round(p.Price, 4), p.Quantity);
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < _dg.Rows.Count; i++)
            {
                decimal price = Convert.ToDecimal(_dg["Price", i].Value);
                int quantity = Convert.ToInt32(_dg["Quantity", i].Value);
                decimal totalAmount = price * quantity;

                _dg["Total_Amount", i].ValueType = typeof(decimal);
                _dg["Total_Amount", i].Value = Math.Round(totalAmount, 4);

            }
        }
    }
}
