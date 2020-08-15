using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class Sword : Item
    {
        //public new ItemType Type { get; set; } = ItemType.Sword;
        //public new int MaxStackableSize { get; set; } = (int)StackSize.Unstackable;

        public Sword() 
        {
            Type = ItemType.Sword;
            MaxStackableSize = (int)StackSize.Unstackable;
        }
    }
}
