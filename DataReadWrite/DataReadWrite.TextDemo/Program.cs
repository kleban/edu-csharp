
using DataReadWrite.DataGenerator;
using DataReadWrite.Managers;

// WRITE DATA
//var data = Library.Generate(10);
IBookReaderWriter manager = new TextDataReaderWriter();

var path = Path.Combine(AppContext.BaseDirectory, "library.txt");
//manager.Write(data, path);

Console.WriteLine("Done!");

// READ DATA

var data = manager.Read(path);
foreach (var item in data)
{
    Console.WriteLine($"{item.Id}. {item.Title}" );
}

