using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class MonsterCR
    {
        public int ID { get; set; }
        public int MonsterMaxCRRating { get; set; }
        public int MonsterMinCRRating{ get; set; }
        public int PlayerCRRating { get; set; }
        public MonsterCR()
        {

        }
        
    }
}
