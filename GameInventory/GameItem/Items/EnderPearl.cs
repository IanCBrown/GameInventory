using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem.Items
{
    class EnderPearl : Item
    {
        public new ItemType Type { get; set; } = ItemType.EnderPearl;
        public new int MaxStackableSize { get; set; } = (int) StackSize.ShortStack;

        public EnderPearl() : base()
        {

        }

        public EnderPearl(int quantity) : base(quantity)
        {

        }
    }
}
