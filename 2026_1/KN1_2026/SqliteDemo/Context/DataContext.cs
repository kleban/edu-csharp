using Microsoft.EntityFrameworkCore;
using SqliteDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteDemo.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sqlite_demo.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
