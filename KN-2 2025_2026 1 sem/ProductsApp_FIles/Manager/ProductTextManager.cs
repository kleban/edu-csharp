using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ProductTextManager : IProductManager
    {
        public List<Product> Read(string path)
        {
            StreamReader reader = null;
            List<Product> products = new List<Product>();

            try
            {
                reader = new StreamReader(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        var product = new Product
                        {
                            Id = int.Parse(parts[0]),
                            Name = parts[1],
                            Price = decimal.Parse(parts[2]),
                            Category = parts[3],
                            Quantity = double.Parse(parts[4])
                        };
                        products.Add(product);
                    }
                }
            }
            catch (FormatException fe)
            {
                throw new FormatException("File format is incorrect", fe);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading file", ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

            }

            return products;
        }

        public void Write(string path, List<Product> products)
        {

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path);

                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Id},{product.Name},{product.Price},{product.Category},{product.Quantity}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing file", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }
    }
}
