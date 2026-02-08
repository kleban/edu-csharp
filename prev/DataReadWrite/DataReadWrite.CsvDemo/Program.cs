
using DataReadWrite.Managers;

IBookReaderWriter manager = new CsvReaderWriter();

var books = manager.Read("library.csv");
foreach(var b in books)
{
    Console.WriteLine($"{b.Id}. {b.Title} ({b.Publisher.City})");
}

manager.Write(books, "library2.csv");

