using System;
namespace GameInventory.GameItem.Items
{
    public class Pickaxe : Item
    {
        public Pickaxe()
        {
            Id = ItemId.Pickaxe;
            MaxStackableSize = (int)StackSize.Unstackable;
            DisplayName = "Pickaxe";
        }
    }
}
