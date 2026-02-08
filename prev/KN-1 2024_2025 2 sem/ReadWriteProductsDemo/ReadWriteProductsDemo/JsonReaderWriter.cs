using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    public class JsonReaderWriter : IProductReaderWriter
    {
        public List<Product> Read(string path)
        {
            var list = new List<Product>();

            // Assuming the JSON file contains an array of products

            string json = File.OpenText(path).ReadToEnd();
            list = JsonSerializer.Deserialize<List<Product>>(json);

            //try-catch
            return list;
        }

        public void Write(List<Product> products, string path)
        {
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true 
            });

            File.WriteAllText(path, json, Encoding.UTF8);

        }
    }
}
