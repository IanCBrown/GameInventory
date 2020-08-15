using System;
using System.Collections.Generic;
using GameInventory.GameItem;

namespace GameInventory
{
    class Inventory
    {
        private List<ItemStack> Items { get; set; }
        //private List<Item> Items { get; set; }
        // Default MaxSize = 10 (i.e. numberkey itemslots)
        public int MaxSize { get; set; } = 10;
        public int CurrSize { get; set; } = 0;

        public Inventory()
        {

        }

        public Inventory(List<ItemStack> items, int maxSize)
        {
            if (items.Count <= maxSize)
            {
                Items = items;
                MaxSize = maxSize;
                CurrSize = items.Count;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Inventory(Inventory inv)
        {
            Items = inv.Items;
            MaxSize = inv.MaxSize;
            CurrSize = inv.CurrSize;
        }


        public ItemStack GetItemAt(int index)
        {
            return Items[index];
        }

        public bool Remove(int index)
        {
            return Items.Remove(GetItemAt(index)).Equals(true);
        }

        public void InsertAt(int index, ItemStack items)
        {
            if (index < MaxSize && index >= 0)
            {
                Items.Insert(index, items);
            }
        }
    }
}
