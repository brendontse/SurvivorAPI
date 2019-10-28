using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Survivor.Models
{
    public class SurvivorContext : DbContext
    {
        public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options)
        {
        } 

        public DbSet<Player> Players {get; set;}
        public DbSet<Season> Seasons {get; set;}
        public DbSet<SeasonPlayer> SeasonPlayers {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>().HasData(
                new Player {
                    PlayerId = 1, 
                    PlayerName = "Boston Rob", 
                    PlayerDays = 117, 
                   
                    }
            );


            builder.Entity<Season>().HasData(
                new Season {
                    SeasonId = 1, 
                    SeasonName = "Marquesas", 
                    
                    }
            );
            builder.Entity<SeasonPlayer>().HasData(
                new SeasonPlayer {
                    SeasonId = 1, 
                    PlayerId = 1,
                    SeasonPlayerId = 1 
                    
                    }
            );
        }
    }
}