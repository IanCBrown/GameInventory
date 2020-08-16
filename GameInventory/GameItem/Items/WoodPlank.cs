using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class WoodPlank : Item
    {
        public WoodPlank()
        {
            Id = ItemId.WoodPlank;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Wood Plank";
        }

        public WoodPlank(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.WoodPlank;
                DisplayName = "WoodPlank";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public WoodPlank(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.WoodPlank;
            DisplayName = "WoodPlank";
        }
    }
}
