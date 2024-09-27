

using DataReadWrite.DataGenerator;
using DataReadWrite.Managers;

//var data = Library.Generate(5);
var jsonManager = new JsonReaderWriter();

//jsonManager.Write(data, "data.json");

foreach(var b in jsonManager.Read("data.json"))
{
    Console.WriteLine(b.Title);
}