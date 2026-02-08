

using DataReadWrite.Managers;

IBookReaderWriter manager = new ExcelReaderWriter();

var books = manager.Read("library2.xlsx");

foreach (var book in books)
{
    book.Id += 20;
    Console.WriteLine($"{book.Id}. {book.Title}");
}

manager.Write(books, "library3.xlsx");