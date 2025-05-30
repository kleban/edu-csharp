using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    public class ProductReaderWriter : IProductReaderWriter
    {
        public void Write(List<Product> products, string path)
        {
            // Implementation for writing products to a file
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path);
                writer.WriteLine("Name;Price;Quantity;Unit"); // Header line
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Name};{product.Price};{product.Quantity};{product.Unit}");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("You do not have permission to write to this file.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(writer is not null)
                { 
                    writer.Flush();
                    writer.Close();
                }
            }
        }

        public List<Product> Read(string path)
        {
            var products = new List<Product>();
            StreamReader reader = null;
            
            try
            {
                reader = new StreamReader(path);
                string line = reader.ReadLine();
                while((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        var product = new Product
                        {
                            Name = parts[0].Trim(),
                            Price = double.Parse(parts[1].Trim()),
                            Quantity = int.Parse(parts[2].Trim()),
                            Unit = parts[3].Trim()
                        };
                        products.Add(product);
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new WrongProductFileException(path);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException("The specified file was not found.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("You do not have permission to access this file.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(reader is not null)
                { 
                    reader.Close();
                }
            }

            return products;
        }
    }

}
