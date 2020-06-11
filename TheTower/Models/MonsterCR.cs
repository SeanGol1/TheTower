using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class MonsterCR
    {
        public int ID { get; set; }
        public string LVLNumber { get; set; }
        public string LVLDesc { get; set; }
        public MonsterCR()
        {

        }
        public MonsterCR(string _lvlnum, string _lvldesc)
        {
            LVLNumber = _lvlnum;
            LVLDesc = _lvldesc;
        }
    }
}
