using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDemo
{
    internal class ProductSortByPriceComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Price > y.Price) return 1;
            if(x.Price < y.Price) return -1;
            return 0;
        }
    }
}
