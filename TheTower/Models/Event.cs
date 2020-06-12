using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public string Description { get; set; }
        public Event()
        {

        }
        public Event(string _name, int _number, string _desc)
        {
            Name = _name;
            RollNumber = _number;
            Description = _desc;
        }
    }
}
