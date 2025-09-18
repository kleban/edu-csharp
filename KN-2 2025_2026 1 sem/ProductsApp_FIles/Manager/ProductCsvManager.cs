using CsvHelper;
using CsvHelper.Configuration;
using Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ProductCsvManager : IProductManager
    {
        private CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false                                    
        };

        public List<Product> Read(string path)
        {
            var records = new List<Product>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {        
                records = csv.GetRecords<Product>().ToList();
            }
            return records;
        }

        public void Write(string path, List<Product> products)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(products);
            }
        }
    }
}
