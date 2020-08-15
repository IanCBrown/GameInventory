using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Shovel : Item
    {
        public new ItemType Type { get; set; } = ItemType.Shovel;
        public new int MaxStackableSize { get; set; } = (int)StackSize.Unstackable;

        public Shovel() : base()
        {

        }
    }
}
