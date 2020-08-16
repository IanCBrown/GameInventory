using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Diamond : Item
    {
        public Diamond()
        {
            Id = ItemId.Diamond;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Diamond";
        }

        public Diamond(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.Diamond;
                DisplayName = "Diamond";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Diamond(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.Diamond;
            DisplayName = "Diamond";
        }
    }
}
