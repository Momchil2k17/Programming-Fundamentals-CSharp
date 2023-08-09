using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0]=="Add")
                {
                    nums.Add(int.Parse(info[1]));
                }
                else if (info[0]=="Remove")
                {
                    nums.Remove(int.Parse(info[1]));
                }
                else if (info[0]=="RemoveAt")
                {
                    nums.RemoveAt(int.Parse(info[1]));
                }
                else if (info[0] == "Insert")
                {
                    nums.Insert(int.Parse(info[2]), int.Parse(info[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
