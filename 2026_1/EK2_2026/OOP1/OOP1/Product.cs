using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product
    {
        //fields
        private string name;
        private double price;
        private double quantity;

        //ctor
        public Product(string name, double price, double quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //methods
        public void ShowInfo()
        {
            Console.WriteLine($"{name} - ${price} x {quantity}");
        }

        //props
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
