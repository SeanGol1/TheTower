using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string Index { get; set; }
        [JsonProperty("challenge_rating")]
        public double ChallengeRating { get; set; }
        [JsonProperty("xp")]
        public int XP { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int RollNumber { get; set; }
        public string ImagePath { get; set; }

        public Monster()
        {

        }
        public Monster(int _MonsterCR,string _index,int _number, string _name, string _page)
        {
            ChallengeRating = _MonsterCR;
            Index = _index;
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

    public class MonsterResponse
    {
        public int Count { get; set; }
        public List<Monster> Results { get; set; }
    }

    public class MonsterCreateViewModel
    {
        public Monster Monster { get; set; }
        public List<Monster> MonsterList { get; set; }
    }
}
