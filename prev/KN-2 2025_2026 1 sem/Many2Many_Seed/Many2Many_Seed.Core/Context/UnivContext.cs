using Many2Many_Seed.Core.Extensions;
using Many2Many_Seed.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many2Many_Seed.Core.Context
{
    public class UnivContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnstring = "Server=.;Database=UnivDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cnstring);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedOurData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
