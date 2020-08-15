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
            Dirt dirt = new Dirt();
            Console.WriteLine(dirt.Type);
            Console.WriteLine(dirt.MaxStackableSize);
        }
    }
}
