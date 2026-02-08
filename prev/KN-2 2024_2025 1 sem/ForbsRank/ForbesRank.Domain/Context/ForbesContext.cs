using ForbesRank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Domain.Context
{
    public class ForbesContext : DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Country> Countries => Set<Country>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=DbForbesRank; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}

