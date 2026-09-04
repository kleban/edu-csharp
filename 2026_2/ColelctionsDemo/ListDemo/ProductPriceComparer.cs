using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product p1, Product p2)
        {
            return p1.Price > p2.Price ? 1 : (p1.Price < p2.Price ? -1 : 0);
        }
    }
}
