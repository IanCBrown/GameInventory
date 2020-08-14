using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    class ItemStack
    {
        public Stack<Item> Items { get; set; }
        public int StackSize { get; set; }
        public Item ItemType { get; set; }
        

        public ItemStack(Item itemType)
        {
            ItemType = itemType;
            Items = new Stack<Item>();
            StackSize = Items.Count;
        }

        public ItemStack(ItemStack itemStack)
        {
            Items = itemStack.Items;
            StackSize = itemStack.StackSize;
            ItemType = itemStack.ItemType;
        }

        public void Add(Item item)
        {
            if (item.Type == ItemType.Type && StackSize <= item.MaxStackableSize)
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
