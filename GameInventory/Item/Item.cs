using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.Item
{
    class Item
    {
        public Items Name { get; set; }
        public int maxStackableSize { get; set; }

        public Item(Items name, int maxStackableSize)
        {
            Name = name;
            this.maxStackableSize = maxStackableSize;
        }

        public Item(Item item)
        {
            Name = item.Name;
            maxStackableSize = item.maxStackableSize;
        }
    }
}
