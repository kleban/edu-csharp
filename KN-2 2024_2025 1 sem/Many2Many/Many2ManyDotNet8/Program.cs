using Many2ManyDotNet8.Context;
using Microsoft.EntityFrameworkCore;

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