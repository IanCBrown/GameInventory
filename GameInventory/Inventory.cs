using System;
using System.Collections.Generic;
using GameInventory.GameItem;

namespace GameInventory
{
    class Inventory
    {
        private List<ItemStack> Items { get; set; }
        public int MaxSize { get; set; }
        public int CurrSize { get; set; }

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

        public bool InsertAt(ItemStack items, int index)
        {
            return false;
        }
    }
}
