using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Session
    {
        public int ID { get; set; }
        public string DMName { get; set; }
        public int PlayerLevel { get; set; }
        public int PlayerQty { get; set; }
        public ICollection<Level> LevelSetup { get; set; }
        public Session()
        {

        }

    }
}
