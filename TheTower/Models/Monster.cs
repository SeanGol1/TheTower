using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public int ChallengeRating { get; set; }
        public int XP { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int RollNumber { get; set; }
        public string ImagePath { get; set; }

        public Monster()
        {

        }
        public Monster(int _MonsterCR,int _number, string _name, string _page)
        {
            ChallengeRating = _MonsterCR;
            Name = _name;
            Source = _page;
            RollNumber = _number;
            ImagePath = Name + ".png";

        }
        /*
        public Monster(string _MonsterCR, string _name, string _page, string _number)
        {
            MonsterCR = _MonsterCR;
            MonsterName = _name;
            MMPage = _page;
            MonsterRdNumber = _number;

        }*/
    }
}
