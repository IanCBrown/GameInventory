using System;
namespace GameInventory.GameItem.Items
{
    public class Sand : Item
    {
        public new ItemType Type { get; set; } = ItemType.Sand;
        public new int MaxStackableSize { get; set; } = (int) StackSize.FullStack;

        public Sand()
        {

        }
    }
}
