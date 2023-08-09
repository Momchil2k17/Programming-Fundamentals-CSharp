using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Z][A-z]+)<< !(?<quantity>[0-9]+)";
            string command = Console.ReadLine();
            List<Furniture> furnitures = new List<Furniture>();
            while (command != "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(command);
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal quantity = decimal.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(new Furniture(name, price, quantity));
                }
                command = Console.ReadLine();
            }
            decimal money = 0;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                money += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {money:f2}");
            
        }
    }
    public class Furniture
    {
        public Furniture(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}
