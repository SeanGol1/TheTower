using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class CRRoll
    {
        public int ID { get; set; }
        public int RollNumber { get; set; }
        public int CRLevel { get; set; }
        public int MonsterCRID { get; set; }
        public int MonsterQTY { get; set; }
        public CRRoll()
        {

        }
    }
}
