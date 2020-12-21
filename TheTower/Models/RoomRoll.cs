using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class RoomRoll
    {

        public int ID { get; set; }
        public int DiceRoll { get; set; }
        public int RoomMove { get; set; }
        public RoomRoll()
        {

        }
        public RoomRoll(int _rnumber, int _roomMove)
        {
            DiceRoll = _rnumber;
            RoomMove = _roomMove;
        }
    }
}
