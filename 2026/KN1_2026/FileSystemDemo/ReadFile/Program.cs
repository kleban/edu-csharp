
using ReadFile;

var path = "d:\\lang_stats_april_24__.csv";

List<LangStats> stats = new List<LangStats>();

StreamReader reader = new StreamReader(path);

var line = reader.ReadLine();
while ((line = reader.ReadLine()) != null)
{
    var data = line.Split(';');
    var obj = new LangStats
    {
        Language = data[0],
        Count = int.Parse(data[1]),
        Percent = double.Parse(data[2]),
    };
    stats.Add(obj);
}
reader.Close();

foreach (var stat in stats)
{
    Console.WriteLine(stat);
}

// Write
//path = "d:\\lang_stats_april_24__.csv";
//StreamWriter writer = new StreamWriter(path);

//writer.WriteLine("Language;Count;Percent");

//foreach (var stat in stats)
//{
//    writer.WriteLine(stat.CsvLine);
//}
//writer.Flush();
//writer.Close();

