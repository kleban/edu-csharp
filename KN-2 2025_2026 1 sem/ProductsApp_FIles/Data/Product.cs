namespace Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double Quantity { get; set; }

        public override string ToString()
        {
            return  $"{Id}. {Name}";
        }

    }
}
