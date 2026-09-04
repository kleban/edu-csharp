

using ShopApp.Models;

Category milkCategory = new Category { Name = "Milk Products" };
Category bakeryCategory = new Category { Name = "Bakery" };

Product p1 = new Product { Name = "Milk", Price = 53.2, StockQuantity = 100, Category = milkCategory  };
OrderItem oi1 = new OrderItem { Product = p1, Quantity = 2 };

Product p2 = new Product { Name = "Bread", Price = 32, StockQuantity = 30, Category = bakeryCategory };
OrderItem oi2 = new OrderItem { Product = p2, Quantity = 3  };

Customer customer = new Customer { Name = "Ivan Petrenko", Age = 24, Gender = Gender.Male };

Order order = new Order
{
    Customer = customer,
    Date = new DateTime(2026, 4, 12, 14, 15, 0),
    PaymentStatus = PaymentStatus.Done,
    OrderItems = new List<OrderItem> { oi1, oi2 }
};

Console.WriteLine(order.GetReceipt());