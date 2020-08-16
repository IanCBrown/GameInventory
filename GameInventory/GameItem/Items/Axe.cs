using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Axe : Item
    {
        public Axe() 
        {
            Id = ItemId.Axe;
            MaxStackableSize = (int)StackSize.Unstackable;
            DisplayName = "Axe";
        }
    }
}
