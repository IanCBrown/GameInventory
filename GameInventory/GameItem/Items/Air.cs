using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Air : Item
    {
        public Air()
        {
            Id = ItemId.Air;
            MaxStackableSize = (int)StackSize.Unstackable;
            DisplayName = "Air";
        }
    }
}
