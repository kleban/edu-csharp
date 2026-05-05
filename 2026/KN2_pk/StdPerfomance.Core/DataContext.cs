using Microsoft.EntityFrameworkCore;
using StdPerfomance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdPerfomance.Core
{
    public class DataContext : DbContext
    {
        public DbSet<StressLevel> StressLevels {  get; set; }

        public DbSet<StudentScore> StudentScores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=StdPerfomanceDb;Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
