using System;
using System.Collections.Generic;
using System.Text;

namespace GameInventory.GameItem
{
    public enum ItemType
    {
        Dirt,
        Sand,
        Gravel,
        Wood,
        Pickaxe,
        Sword,
        Axe,
        Shovel,
        EnderPearl
    }

    public enum StackSize:int
    {
        Unstackable = 1,
        ShortStack = 16,
        FullStack = 64
    }
}
