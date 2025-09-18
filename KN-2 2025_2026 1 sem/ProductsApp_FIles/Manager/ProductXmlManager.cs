using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manager
{
    public class ProductXmlManager : IProductManager
    {
        public List<Product> Read(string path)
        {
           XDocument xdoc = XDocument.Load(path);
            var p = xdoc.Root.Elements("products");

            foreach (var item in p)
            {
                var prod = new Product
                {
                item.Attribute("id").Value;
                item.Element("name").Value;
                item.Element("price").Value;
                item.Element("quantity").Value;
                item.Element("category").Value;
                    }
            }
        }

        public void Write(string path, List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
