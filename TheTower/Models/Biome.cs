using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Biome
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string Description { get; set; }
        public Biome()
        {

        }
        public Biome(string _name, String _number, String _desc)
        {
            Name = _name;
            RollNumber = _number;
            Description = _desc;
        }
    }
}
