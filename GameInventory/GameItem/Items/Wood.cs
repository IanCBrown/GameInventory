﻿using System;

namespace GameInventory.GameItem.Items
{
    public class Wood : Item
    {
        public Wood()
        {
            Id = ItemId.Wood;
            MaxStackableSize = (int)StackSize.FullStack;
            DisplayName = "Wood";
        }

        public Wood(int quantity)
        {
            MaxStackableSize = (int)StackSize.FullStack;
            if (quantity <= MaxStackableSize)
            {
                DisplayName = "Wood";
                Id = ItemId.Wood;
                Quantity = quantity;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Wood(int quantity, int maxStackableSize) : base(quantity, maxStackableSize)
        {
            Id = ItemId.Wood;
            DisplayName = "Wood";
        }
    }
}
