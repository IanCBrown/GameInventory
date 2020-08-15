using System;
using GameInventory.GameItem;
using GameInventory.GameItem.Items;

namespace GameInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GameInventory Prototype!");

            Inventory inventory = new Inventory();
            Item dirt = new Item(ItemType.Dirt);
            Item sword = new Item();
            Item sand = new Item(64);
            Item shovel = new Item();
            sand.DecrementBy(32);

            inventory.Add(dirt);
            inventory.Add(sword);
            inventory.Add(sand);
            inventory.Add(shovel);

            Console.WriteLine(inventory.ToString());

            EnderPearl ep = new EnderPearl(18);
            Console.WriteLine(ep.ToString());

            Ax ax = new Ax();
            Console.WriteLine(ax.ToString());
        }
    }
}
