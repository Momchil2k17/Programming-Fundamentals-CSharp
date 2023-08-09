using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> line = Console.ReadLine().Split(" ").ToList();
                if (line.Count==3)
                {
                    if (guests.Contains(line[0]))
                    {
                        Console.WriteLine($"{line[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(line[0]);
                    }
                }
                else if (line.Count==4)
                {
                    if (guests.Contains(line[0]))
                    {
                        guests.Remove(line[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{line[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
