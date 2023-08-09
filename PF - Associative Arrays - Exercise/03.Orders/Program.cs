using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<decimal>>();
            string command = Console.ReadLine();
            while (command!="buy")
            {
                string[] info = command.Split(" ").ToArray();
                string key = info[0];
                decimal price = decimal.Parse(info[1]);
                decimal quantity = decimal.Parse(info[2]);
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key][0] = price;
                    dictionary[key][1] += quantity;
                }
                else
                {
                    dictionary[key] = new List<decimal>();
                    dictionary[key].Add(price);
                    dictionary[key].Add(quantity);
                }
                command = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0]*kvp.Value[1]:f2}");
            }
        }
    }
}
