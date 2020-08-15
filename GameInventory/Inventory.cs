using System;
using System.Collections.Generic;
using System.Text;
using GameInventory.GameItem;

namespace GameInventory
{
    class Inventory
    {
        //private List<ItemStack> Items { get; set; }
        private List<Item> Items { get; set; } = new List<Item>();
        // Default MaxSize = 10 (i.e. numberkey itemslots)
        public int MaxSize { get; set; } = 10;
        public int CurrSize { get; set; } = 0;

        public Inventory()
        {
            
        }

        public Inventory(List<Item> items, int maxSize)
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


        public Item GetItemAt(int index)
        {
            return Items[index];
        }

        public bool Remove(int index)
        {
            return Items.Remove(GetItemAt(index)).Equals(true);
        }

        public void InsertAt(int index, Item item)
        {
            if (index < MaxSize && index >= 0 && Items.Count < MaxSize)
            {
                Items.Insert(index, item);
            }
        }

        // always adds to tail. 
        public void Add(Item item)
        {
            if (Items.Count < MaxSize)
            {
                Items.Add(item);
            }
        }

        public override string ToString()
        {
            StringBuilder inventorySB = new StringBuilder();
            for (int i = 0; i < Items.Count; i++)
            {
                inventorySB.Append(Items[i].ToString());
                if (i + 1 < Items.Count)
                {
                    inventorySB.Append("|");
                }
            }
            return inventorySB.ToString();
        }
    }
}
