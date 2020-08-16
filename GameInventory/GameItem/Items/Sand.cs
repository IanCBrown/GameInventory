using System;
namespace GameInventory.GameItem.Items
{
    public class Sand : Item
    {
        public Sand()
        {
            Id = ItemId.Sand;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Sand";
        }

        public Sand(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.Sand;
                DisplayName = "Sand";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Sand(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.Sand;
            DisplayName = "Sand";
        }
    }
}
