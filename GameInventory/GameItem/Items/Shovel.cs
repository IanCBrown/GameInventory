﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Shovel : Item
    {
        public Shovel()
        {
            Id = ItemId.Shovel;
            MaxStackableSize = (int)StackSize.Unstackable;
            DisplayName = "Shovel";
        }
    }
}
