using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTower.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemCost { get; set; }
        public string Vendor { get; set; }
        public Item()
        {

        }
        public Item(string _name, string _cost, string _vendor)
        {
            ItemName = _name;
            ItemCost = _cost;
            Vendor = _vendor;
        }
    }
}
