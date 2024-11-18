

using Many2ManyPlusSelfRef.Context;
using Microsoft.EntityFrameworkCore;

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