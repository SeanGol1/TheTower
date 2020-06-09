using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class TowerContext : DbContext
    {
        public TowerContext()
        {

        }
       
        public DbSet<Biom> Biom { get; set; }
        public DbSet<Event> Event{ get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<MonsterCR> MonsterCR { get; set; }
        public DbSet<Monster> RoomEvent { get; set; }
        public DbSet<Item> RoomNumber { get; set; }
        public DbSet<Monster> Session { get; set; }

    }
}
