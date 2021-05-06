using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Char { get; set; }
        public int Init  { get; set; }
        public int SessionId { get; set; }

        public Player()
        {

        }
    }
}
