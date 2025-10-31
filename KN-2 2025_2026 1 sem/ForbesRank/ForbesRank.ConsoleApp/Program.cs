
using CsvHelper;
using ForbesRank.ConsoleApp.Model;
using System.Globalization;

IEnumerable<ForbsDataItem> data = new List<ForbsDataItem>();

using (var reader = new StreamReader("data/forbes_2022_billionaires.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<ForbsDataItem>().ToList();
}

foreach (var item in data.Take(10))
{
    Console.WriteLine($"{item.rank} - {item.personName} - {item.birthDate.Value.ToString("dd MMM yyyy", new CultureInfo("uk-UA"))}");
}



