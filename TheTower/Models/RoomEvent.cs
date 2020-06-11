using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class RoomEvent
    {
        public int ID { get; set; }
        public String RoomNumber { get; set; }
        public String EventName { get; set; }
        public RoomEvent()
        {

        }
        public RoomEvent(string _rNumber, string _EName)
        {
            RoomNumber = _rNumber;
            EventName = _EName;
        }
    }
}
