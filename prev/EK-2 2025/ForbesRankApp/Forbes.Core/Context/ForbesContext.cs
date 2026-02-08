using Forbes.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbes.Core.Context
{
    public class ForbesContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WS25; Database=forbes_db; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
