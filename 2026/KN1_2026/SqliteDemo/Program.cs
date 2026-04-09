
using Microsoft.EntityFrameworkCore;
using SqliteDemo.Context;

using (var ctx = new DataContext())
{
    ctx.Products.ToList().ForEach(Console.WriteLine);
}
