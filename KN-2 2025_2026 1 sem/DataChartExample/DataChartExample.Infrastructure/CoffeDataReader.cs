using CsvHelper;
using CsvHelper.Configuration;
using DataChartExample.Domain;
using System.Globalization;
using System.Linq;

namespace DataChartExample.Infrastructure
{
    public class CoffeDataReader
    {
        static CsvConfiguration config = new CsvConfiguration(CultureInfo.GetCultureInfo("en-GB")) // dd/MM/yyyy
        {
            HasHeaderRecord = true,
            BadDataFound = null,
            MissingFieldFound = null,
            PrepareHeaderForMatch = args => args.Header.Trim()
        };
        public static List<CoffeDataItem> Read(string path)
        {
            var records = new List<CoffeDataItem>();
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.TypeConverterOptionsCache
                   .GetOptions<DateTime>()
                   .Formats = new[] { "dd/MM/yyyy", "d/M/yyyy" };
                                
                records = csv.GetRecords<CoffeDataItem>().ToList();
                reader.Close();
            }
            return records;
        }
    }
}
