using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    // deprecated
    class ItemStack
    {
        public Stack<Item> Items { get; set; }
        public int Size { get; set; }
        public Item ItemType { get; set; }
        

        public ItemStack(Item itemType)
        {
            ItemType = itemType;
            Items = new Stack<Item>();
            Size = Items.Count;
        }

        public ItemStack(ItemStack itemStack)
        {
            Items = itemStack.Items;
            Size = itemStack.Size;
            ItemType = itemStack.ItemType;
        }

        public void Add(Item item)
        {
            if (item.Type == ItemType.Type && Size <= item.MaxStackableSize)
            {
                Items.Push(item);
            }
        }

        public void Remove()
        {
            if (Items.Count > 0)
            {
                Items.Pop();
            }
        }
    }
}
