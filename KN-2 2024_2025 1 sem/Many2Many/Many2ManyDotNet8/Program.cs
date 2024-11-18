using Many2ManyDotNet8.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var ctx = new UniContext();

foreach(var t in ctx.Teachers.Include(x=> x.Courses))
{
    Console.WriteLine($"{t.Name} -----------");
    foreach(var c in t.Courses)
    {
        Console.WriteLine($"\t{c.Title}");
    }
    Console.WriteLine();
}

var date = DateTime.ParseExact("23..Jan..24 01:20", "dd..MMM..yy HH:mm", new CultureInfo("en"));
Console.WriteLine(date);