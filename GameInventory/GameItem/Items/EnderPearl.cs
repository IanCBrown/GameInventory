using System;

namespace GameInventory.GameItem.Items
{
    class EnderPearl : Item
    {
        public EnderPearl()
        {
            Id = ItemId.EnderPearl;
            MaxStackableSize = (int)StackSize.ShortStack;
            DisplayName = "Ender Pearl";
            Quantity++;

        }

        public EnderPearl(int quantity)
        {
            MaxStackableSize = (int)StackSize.ShortStack;
            if (quantity <= MaxStackableSize)
            {
                Id = ItemId.EnderPearl;
                DisplayName = "Ender Pearl";
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public EnderPearl(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.EnderPearl;
            DisplayName = "Ender Pearl";
        }
    }
}
