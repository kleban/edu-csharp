using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DataReadWright.Services
{
    public class CsvDataManager : IDataManager
    {
        public List<Student> LoadData(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,
                IgnoreBlankLines = true
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<Student>().ToList();
                return records;
            }
        }

        public void SaveData(List<Student> std, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(std);
            }
        }
    }
}
