using System;
namespace GameInventory.GameItem.Items
{
    public class Dirt : Item
    {
        public new ItemType Type { get; set; } = ItemType.Dirt;
        public new int MaxStackableSize { get; set; } = (int) StackSize.FullStack;

        public Dirt()
        {

        }

        public Dirt(int quantity)
        {
            if (quantity <= MaxStackableSize)
            {
                Quantity = quantity;
            }
        }
    }
}
