using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTower.Models;

namespace TheTower.Models
{
    public class TowerContext : DbContext
    {
        public TowerContext()
        {

        }
        public TowerContext(DbContextOptions<TowerContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Biome>().HasData(
                new Biome
                {
                    ID = 12,
                    Name = "Arctic",
                    RollNumber = 1,
                    Description = "Arctic"

                },
                new Biome
                {
                    ID = 1,
                    Name = "Coastal",
                    RollNumber = 2,
                    Description = "Coastal"
                },
                new Biome
                {
                    ID = 2,
                    Name = "Desert",
                    RollNumber = 3,
                    Description = "Desert"

                },
                new Biome
                {
                    ID = 3,
                    Name = "Forest",
                    RollNumber = 4,
                    Description = "Forest"
                },
                new Biome
                {
                    ID = 4,
                    Name = "Grassland",
                    RollNumber = 5,
                    Description = "Grassland"

                },
                new Biome
                {
                    ID = 5,
                    Name = "Hill",
                    RollNumber = 6,
                    Description = "Hill"
                },
                new Biome
                {
                    ID = 6,
                    Name = "Mountain",
                    RollNumber = 7,
                    Description = "Mountain"

                },
                new Biome
                {
                    ID = 7,
                    Name = "Swamp",
                    RollNumber = 8,
                    Description = "Swamp"
                },
                new Biome
                {
                    ID = 8,
                    Name = "Underdark",
                    RollNumber = 9,
                    Description = "Underwater"

                },
                new Biome
                {
                    ID = 9,
                    Name = "Urban",
                    RollNumber = 10,
                    Description = "Urban"
                },
                new Biome
                {
                    ID = 10,
                    Name = "DM Chooses",
                    RollNumber = 11,
                    Description = "DM Chooses"

                },
                new Biome
                {
                    ID = 11,
                    Name = "DM Chooses",
                    RollNumber = 12,
                    Description = "DM Chooses"
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    ID = 8,
                    Name = "Shrink",
                    RollNumber = 1,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 1,
                    Name = "Grow",
                    RollNumber = 2,
                    Description = "Players grow one size up"
                },
                new Event
                {
                    ID = 2,
                    Name = "Event",
                    RollNumber = 3,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 3,
                    Name = "Shrink",
                    RollNumber = 4,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 4,
                    Name = "Shrink",
                    RollNumber = 5,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 5,
                    Name = "Shrink",
                    RollNumber = 6,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 6,
                    Name = "Shrink",
                    RollNumber = 7,
                    Description = "Players shrink down one size"
                },
                new Event
                {
                    ID = 7,
                    Name = "Shrink",
                    RollNumber = 8,
                    Description = "Players shrink down one size"
                }
            );
        }

        public DbSet<Biome> Biome { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<RoomRoll> RoomRoll { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<MonsterCR> MonsterCR { get; set; }
        public DbSet<Monster> RoomEvent { get; set; }
        public DbSet<Item> RoomNumber { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<CRRoll> CRRoll { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Level> Level { get; set; }

        
    }
}
