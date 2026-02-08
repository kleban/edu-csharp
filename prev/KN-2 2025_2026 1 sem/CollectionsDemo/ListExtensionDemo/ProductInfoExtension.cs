using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensionDemo
{
    public static class ProductInfoExtension
    {
        public static string GetInfo(this Product product)
        {
            string info = $"Product Name: {product.Name}, Price: {product.Price:f2}, Quantity: {product.Quantity:f2}";
            return info;
        }
    }
}
