using System;
namespace GameInventory.GameItem.Items
{
    public class Wood : Item
    {
        public new ItemType Type { get; set; } = ItemType.Wood;
        public new int MaxStackableSize { get; set; } = (int) StackSize.FullStack;

        public Wood() : base()
        {

        }

        public Wood(int quantity) : base(quantity)
        {

        }
    }
}
