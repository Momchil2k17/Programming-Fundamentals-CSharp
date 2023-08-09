using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (command != "end")
            {
                string[] info = command.Split(" ").ToArray();
                string serialNum = info[0];
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                decimal itemPrice = decimal.Parse(info[3]);
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNum, item, itemQuantity);
                boxes.Add(box);
                command = Console.ReadLine();
            }
            foreach (Box box in boxes.OrderByDescending(x=>x.Price))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get 
            {
                return Item.Price * ItemQuantity;
            }
        }

    }
}
