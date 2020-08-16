using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Flower : Item
    {
        public Flower()
        {
            Id = ItemId.Wood;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Flower";
        }

        public Flower(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.Flower;
                DisplayName = "Flower";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Flower(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.Flower;
            DisplayName = "Flower";
        }
    }
}
