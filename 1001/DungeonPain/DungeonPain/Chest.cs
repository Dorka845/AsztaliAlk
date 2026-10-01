using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonPain
{
    class Chest
    {
        public int Gold;
        public List<Item> Items = new List<Item>();

        public Chest(int gold, params Item[] items)
        {
            Gold = gold;
            Items.AddRange(items);
        }
    }
}
