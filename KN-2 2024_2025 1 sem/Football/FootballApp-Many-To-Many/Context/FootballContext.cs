using FootballApp_Many_To_Many.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp_Many_To_Many.Context
{
    public class FootballContext : DbContext
    {
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Team> Team => Set<Team>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=football_db; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1,  Name = "Dynamo" },
                new Team { Id = 2, Name = "Real" },
                new Team { Id = 3, Name = "Arsenal" });

            modelBuilder.Entity<Game>().HasOne(x => x.AwayTeam).WithMany(x => x.AwayGames).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Game>().HasOne(x => x.HomeTeam).WithMany(x => x.HomeGames).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

    }
}
