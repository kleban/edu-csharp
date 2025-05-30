using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    public interface IProductReaderWriter
    {
        void Write(List<Product> products, string path);
        List<Product> Read(string path);
    }
}
