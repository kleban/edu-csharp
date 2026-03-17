using OOP1;

Product[] products = new Product[2];
products[0] = new Product("Milk", 0.95, 10);
products[1] = new Product("Car", 12500, 3);

foreach (var product in products)
{
    product.ShowInfo();
}