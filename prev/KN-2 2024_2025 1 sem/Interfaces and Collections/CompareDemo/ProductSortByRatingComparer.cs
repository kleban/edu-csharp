using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDemo
{
    internal class ProductSortByRatingComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.Rating > y.Rating ? 1 : (x.Rating < y.Rating ? -1 : 0);
        }
    }
}
