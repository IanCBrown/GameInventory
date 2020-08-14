using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GameInventory
{
    class Inventory
    {
        private List<Item> Items { get; set; }
        public int maxSize { get; set; }
        public int currSize { get; set; }

        public Inventory(List<Item> items, int maxSize)
        {
            if (items.Count <= maxSize)
            {
                this.Items = items;
                this.maxSize = maxSize;
                this.currSize = items.Count;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Inventory(Inventory inv)
        {
            Items = inv.Items;
            maxSize = inv.maxSize;
            currSize = inv.currSize;
        }


        public Item GetItemAt(int index)
        {
            return Items[index];
        }

        public bool Remove(int index)
        {
            return Items.Remove(GetItemAt(index)).Equals(true);
        }

        public bool insertAt(Item item, int index)
        {
            return false;
        }
    }
}
