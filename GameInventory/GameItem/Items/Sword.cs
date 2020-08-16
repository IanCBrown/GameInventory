using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Sword : Item
    {
        public Sword()
        {
            Id = ItemId.Sword;
            MaxStackableSize = (int)StackSize.Unstackable;
            DisplayName = "Sword";
        }
    }
}
