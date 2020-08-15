using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Ax : Item
    {
        public new ItemType Type { get; set; } = ItemType.Axe;
        public new int MaxStackableSize { get; set; } = (int)StackSize.Unstackable;

        public Ax() 
        {

        }
    }
}
