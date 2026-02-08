using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class FContext : DbContext
    {
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Game> Games => Set<Game>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=football_db; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasMany(x=> x.HomeGames).WithOne(x => x.HomeTeam).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>().HasMany(x => x.AwayGames).WithOne(x => x.AwayTeam).OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }

    }
}
