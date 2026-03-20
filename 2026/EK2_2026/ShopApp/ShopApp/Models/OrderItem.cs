using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }
    }
}
