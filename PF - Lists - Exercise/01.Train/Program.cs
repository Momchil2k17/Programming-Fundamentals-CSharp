using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0] == "Add")
                {
                    wagons.Add(int.Parse(info[1]));
                }
                else
                {
                    int addPassanger = int.Parse(info[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + addPassanger <= capacity)
                        {
                            wagons[i] += addPassanger;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
