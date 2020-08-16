using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GameInventory.GameItem;
using GameInventory.GameItem.Items;

namespace GameInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GameInventory Prototype!");
            var inventory = FillInventory();
            Console.WriteLine(inventory.ToString());

            string filename = @"..\..\..\GameItem\Items\items.json";
            SerializeToJson(filename);
        }

        static void SerializeToJson(string filename)
        {
            List<Item> toSerialize = new List<Item>
            {
                new Air(),
                new Axe(),
                new Diamond(),
                new Dirt(),
                new EnderPearl(),
                new Flower(),
                new Pickaxe(),
                new Sand(),
                new Shovel(),
                new Sword(),
                new Wood(),
                new WoodPlank()
            };

            string jsonString;
            jsonString = JsonSerializer.Serialize(toSerialize);
            File.WriteAllText(filename, jsonString);
        }

        static Inventory FillInventory()
        {
            Inventory inventory = new Inventory();
            inventory.Add(new Axe());
            inventory.Add(new Diamond(64));
            inventory.Add(new Dirt(64));
            inventory.Add(new EnderPearl(16));
            inventory.Add(new Flower(64));
            inventory.Add(new Pickaxe());
            inventory.Add(new Sand(64));
            inventory.Add(new Shovel());
            inventory.Add(new Sword());
            inventory.Add(new Wood(64));
            inventory.Add(new WoodPlank(64));
            return inventory;
        }
    }
}
