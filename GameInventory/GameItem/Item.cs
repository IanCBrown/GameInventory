using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    public class Item
    {
        public ItemType Type { get; set; }
        public int MaxStackableSize { get; set; }
        public int Quantity { get; set; } = 0; 

        public Item()
        {
            Quantity++;
        }

        public Item(ItemType type)
        {
            Type = type;
        }

        public Item(ItemType type, int quantity, int maxStackableSize)
        {
            Type = type;
            Quantity = quantity;
            MaxStackableSize = maxStackableSize;
        }

        public Item(Item item)
        {
            Type = item.Type;
            Quantity = item.Quantity;
            MaxStackableSize = item.MaxStackableSize;
        }
    }
}
