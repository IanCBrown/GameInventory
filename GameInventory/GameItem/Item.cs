using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    public class Item
    {
        public ItemId Id { get; set; }
        public int MaxStackableSize { get; set; }
        public int Quantity { get; set; } = 0; 
        public string DisplayName { get; set; }

        public Item()
        {
            Quantity++;
        }

        public Item(int quantity)
        {

        }

        public Item(int quantity, int maxStackableSize)
        {
            switch (maxStackableSize)
            {
                case (int)StackSize.FullStack:
                    if (quantity <= (int)StackSize.FullStack && quantity > 0)
                    {
                        Quantity = quantity;
                        MaxStackableSize = maxStackableSize;
                    }
                    break;
                case (int)StackSize.ShortStack:
                    if (quantity <= (int)StackSize.FullStack && quantity > 0)
                    {
                        Quantity = quantity;
                        MaxStackableSize = maxStackableSize;
                    }
                    break;
            }
        }

        public Item(Item item)
        {
            Id = item.Id;
            MaxStackableSize = item.MaxStackableSize;
            Quantity = item.Quantity;
            DisplayName = item.DisplayName;
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
            return GetType().Name + ":" + Quantity;
        }
    }
}
