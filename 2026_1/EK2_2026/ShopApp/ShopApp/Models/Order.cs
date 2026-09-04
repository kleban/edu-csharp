using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShopApp.Models
{
    public class Order
    {
        public DateTime Date { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
        public double Calculate()
        {
            double total = 0;
            foreach (var item in OrderItems)
            {
                total += item.Product.Price * item.Quantity;
            }
            return total;
        }

        public string GetReceipt()
        {
            CultureInfo culture = new CultureInfo("uk-UA");
            string str = "------------ SHOP NAME ----------\n";
            str += $"Order Date:\t\t{Date.ToString("dd MMMM yyyy HH год. mm хв.", culture)}\n\n";
            foreach (var item in OrderItems)
            {
                str += $"{item.Product.Name}\t{item.Product.Price:0.00}x{item.Quantity:0.00}\t{item.Product.Price * item.Quantity} UAH\n";
            }
            str += $"Total\t\t\t{Calculate():0.00} UAH\n\n";
            return str;

        }
    }
}
