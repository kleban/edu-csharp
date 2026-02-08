using Many2ManyPlusSelfRef.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many2ManyPlusSelfRef.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Size> Sizes => Set<Size>();
        public DbSet<Clothing> Cloths => Set<Clothing>();
        public DbSet<Category> Categories => Set<Category>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=store; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, Title = "S"},
                new Size { Id = 2, Title = "M" },
                new Size { Id = 3, Title = "L" },
                new Size { Id = 4, Title = "XL" },
                new Size { Id = 6, Title = "XXL" }
                );

            modelBuilder.Entity<Clothing>().HasMany(x => x.Sizes).WithMany(x=> x.Cloths);            
            
            modelBuilder.Entity<Category>().HasMany(x => x.SubCategories).WithOne(x=> x.Parent);

            base.OnModelCreating(modelBuilder);
        }
    }
}
