using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    class Item
    {
        public Items Type { get; set; }
        public int MaxStackableSize { get; set; }
        

        public Item(Items type, int maxStackableSize)
        {
            Type = type;
            MaxStackableSize = maxStackableSize;
        }

        public Item(Item item)
        {
            Type = item.Type;
            MaxStackableSize = item.MaxStackableSize;
        }
    }
}
