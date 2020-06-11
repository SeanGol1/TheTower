using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string EventNumber { get; set; }
        public string EventDesc { get; set; }
        public Event()
        {

        }
        public Event(string _number, string _desc)
        {
            EventNumber = _number;
            EventDesc = _desc;
        }
    }
}
