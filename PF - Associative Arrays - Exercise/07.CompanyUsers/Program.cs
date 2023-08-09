using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] info = command.Split(" ").ToArray();
                if (!dictionary.ContainsKey(info[0]))
                {
                    dictionary[info[0]] = new List<string>();
                }
                if (!dictionary[info[0]].Contains(info[2]))
                {
                    dictionary[info[0]].Add(info[2]);
                }
                command = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
