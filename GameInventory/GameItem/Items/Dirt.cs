using System;
using System.Dynamic;

namespace GameInventory.GameItem.Items
{
    public class Dirt : Item
    {
        public Dirt()
        {
            Id = ItemId.Dirt;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Dirt";
        }

        public Dirt(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.Dirt;
                DisplayName = "Dirt";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Dirt(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.Dirt;
            DisplayName = "Dirt";
        }
    }
}
