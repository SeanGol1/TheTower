using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string MonsterCR { get; set; }
        public string MonsterName { get; set; }
        public string MMPage { get; set; }
        public string MonsterRdNumber { get; set; }

        public string ImagePath { get; set; }

        public Monster()
        {

        }
        public Monster(string _MonsterCR, string _name, string _page)
        {
            MonsterCR = _MonsterCR;
            MonsterName = _name;
            MMPage = _page;
            ImagePath = MonsterName + ".png";

        }

        public Monster(string _MonsterCR, string _name, string _page, string _number)
        {
            MonsterCR = _MonsterCR;
            MonsterName = _name;
            MMPage = _page;
            MonsterRdNumber = _number;

        }
    }
}
