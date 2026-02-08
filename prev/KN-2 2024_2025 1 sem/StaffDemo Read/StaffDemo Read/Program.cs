// See https://aka.ms/new-console-template for more information
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

using (var reader = new StreamReader("staff.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    csv.Context.RegisterClassMap<DataMap>();
    var records = csv.GetRecords<Data>();

    foreach (var r in records)
    {
        Console.WriteLine($"{r.Id} - {r.Name} - { r.DoB}");
    }
}

public class Data
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DoB { get; set; }
}

public sealed class DataMap : ClassMap<Data>
{
    public DataMap()
    {
        Map(m => m.Id).Name("ID");
        Map(m => m.Name).Name("Name");
        Map(m => m.DoB).Name("Дата_народження");
    }
}