using Microsoft.EntityFrameworkCore;
using OnlineOffline.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOffline.Core
{
    public class LearningContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<LearningResult> Results { get; set; }
        public DbSet<LearningMode> Modes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearningDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
