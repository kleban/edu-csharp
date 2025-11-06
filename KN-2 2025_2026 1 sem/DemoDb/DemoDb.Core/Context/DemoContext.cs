using DemoDb.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDb.Core.Context
{
    public class DemoContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnstring = "Server=.;Database=DbDemo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cnstring);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
