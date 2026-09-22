using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesApp.ConsoleApp.Models
{
    public class Membership
    {
        private string title;
        private decimal price;

        public Membership(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public string Title { get { return title; } } 
        public decimal Price { get { return price; } }
    }
}
