using Biz.Data.Models;
using Biz.Management.Parser;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Biz.Management
{
    public class CsvDataManager : IDataManager
    {
        public List<Business> Read(string path)
        {
            var list = new List<Business>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                list = csv.GetRecords<Business>().ToList();
            }

            return list;
        }

        public void Write(string path, List<Business> biz)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(biz);
            }
        }
    }
}
