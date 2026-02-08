

using DataReadWrite.DataGenerator;
using DataReadWrite.Managers;

var manager = new XmlReaderWriter();

foreach(var b in manager.Read("library.xml"))
{
    Console.WriteLine($"{b.Id}, {b.Title}");
}

manager.Write(Library.Generate(10), "library2.xml");