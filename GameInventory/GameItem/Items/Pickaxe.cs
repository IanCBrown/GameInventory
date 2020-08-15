using System;
namespace GameInventory.GameItem.Items
{
    public class Pickaxe : Item
    {
        public new ItemType Type { get; set; } = ItemType.Pickaxe;
        public new int MaxStackableSize { get; set; } = (int) StackSize.Unstackable;

        public Pickaxe() : base()
        {

        }
    }
}
