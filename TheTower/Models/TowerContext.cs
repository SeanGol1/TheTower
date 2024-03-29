﻿using Microsoft.EntityFrameworkCore;
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
