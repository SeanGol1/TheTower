using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Biome
    {
        public int ID { get; set; }
        public string BiomeNumber { get; set; }
        public string Description { get; set; }
        public Biome()
        {

        }
        public Biome(String _number, String _desc)
        {
           // BiomeNumber = _number;
           // Description = _desc;
        }
    }
}
