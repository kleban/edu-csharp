

using Many2ManyPlusSelfRef.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var ctx = new StoreContext();

foreach(var c in ctx.Cloths.Include(x=> x.Sizes))
{
    Console.Write($"-- {c.Title}: {string.Join(", ", c.Sizes.Select(x=> x.Title))}\n\n");    
}

foreach(var c in ctx.Categories.Where(x=> x.Parent == null).Include(x=> x.SubCategories).ThenInclude(x=> x.SubCategories))
{
    Console.WriteLine($"-- {c.Title}");
    foreach(var c1 in c.SubCategories)
    {
        Console.WriteLine($"-- -- {c1.Title}");

        foreach (var c2 in c1.SubCategories)
        {
            Console.WriteLine($"-- -- -- {c2.Title}");
        }
    }
}

var date = DateTime.ParseExact("October .. 10 / 2024", "MMMM .. dd / yyyy", new CultureInfo("en"));
Console.WriteLine(date);