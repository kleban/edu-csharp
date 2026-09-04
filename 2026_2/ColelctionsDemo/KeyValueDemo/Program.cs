
List<KeyValuePair<string, int>> data = new();

data.Add(new KeyValuePair<string, int>("Ivan", 89));
data.Add(new KeyValuePair<string, int>("Olena", 90));
data.Add(new KeyValuePair<string, int>("Olena", 76));
data.Add(new KeyValuePair<string, int>("Oleh", 98));
data.Add(new KeyValuePair<string, int>("Oleh", 87));
data.Add(new KeyValuePair<string, int>("Olha", 97));

foreach(var item in data)
{
    Console.WriteLine(item.Value);
}

//var avg = data.Average(x => x.Value);

var avg = data.Select(x=> x.Value).Average(); // List<int>

Console.WriteLine($"{avg:0.00}");