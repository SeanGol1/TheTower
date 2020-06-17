using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Level
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public int RoomLevel{ get; set; }
        public int BiomeID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }
        public int CRLevel { get; set; }
        public int SessionID { get; set; }
        //public ICollection<Session> Session { get; set; }
        public Level()
        {

        }
        /*
        public Level(string _number, string _room)
        {
            Number = _number;
            Room = _room;
        }
        */
    }
}
