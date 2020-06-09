using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Session
    {
        public int ID { get; set; }
        public ICollection<RoomNumber> LevelSetup { get; set; }

    }
}
