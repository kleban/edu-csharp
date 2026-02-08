

using DataReadWrite.Managers;
using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

var manager = new ExcelReaderWriter();
var books = manager.Read("library2.xlsx");
foreach(var b in books)
{
    b.Id += 10;
    Console.WriteLine($"{b.Id} {b.Title}");
}

manager.Write(books, "libraryX2.xlsx");