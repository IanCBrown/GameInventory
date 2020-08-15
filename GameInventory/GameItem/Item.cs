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

        public Item(int quantity)
        {
            Quantity = quantity;
        }

        public Item(ItemType type)
        {
            Type = type;
            Quantity++;
        }

        public Item(ItemType type, int quantity, int maxStackableSize)
        {
            Type = type;
            if (quantity <= maxStackableSize)
            {
                Quantity = quantity;
                MaxStackableSize = maxStackableSize;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Item(Item item)
        {
            Type = item.Type;
            Quantity = item.Quantity;
            MaxStackableSize = item.MaxStackableSize;
        }

        public void Increment()
        {
            if (Quantity < MaxStackableSize)
            {
                Quantity++;
            }
        }

        public void IncrementBy(int num)
        {
            if (Quantity + num <= MaxStackableSize)
            {
                Quantity += num;
            }
        }

        public void Decrement()
        {
            if (Quantity > 0)
            {
                Quantity--;
            }
        }

        public void DecrementBy(int num)
        {
            if (Quantity - num >= 0)
            {
                Quantity -= num;
            }
        }

        public override string ToString()
        {
            return Type + ":" + Quantity;
        }
    }
}
