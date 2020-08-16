
using System.Collections.Generic;


namespace GameInventory.GameItem
{
    public enum ItemId
    {
        Dirt,
        Sand,
        Gravel,
        Wood,
        Pickaxe,
        Sword,
        Axe,
        Shovel,
        EnderPearl,
        Air,
        WoodPlank,
        Flower,
        Diamond
    }

    public enum StackSize : int
    {
        Unstackable = 1,
        ShortStack = 16,
        FullStack = 64
    }

    public class TypeMap
    {
        public Dictionary<ItemId, StackSize> Properties = new Dictionary<ItemId, StackSize>();
        
        public TypeMap()
        {
            Properties.Add(ItemId.Dirt, StackSize.FullStack);
        }
    }
}
