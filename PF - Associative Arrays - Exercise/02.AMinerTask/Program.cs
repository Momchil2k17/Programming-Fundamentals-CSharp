using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while (command!="stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(resource))
                {
                    dictionary[resource] = 0;
                }
                dictionary[resource] += quantity;
                command = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
