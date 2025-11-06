using FrbsApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace FrbsApp.Core.Context
{
    public class FrbsContext : DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<City> Cities => Set<City>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnstring = "Server=.;Database=Forbes_DB_v2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cnstring);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
