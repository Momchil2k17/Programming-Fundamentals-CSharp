using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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
                if (info[0] == "Delete")
                {
                    int deleteNum = int.Parse(info[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]==deleteNum)
                        {
                            nums.Remove(nums[i--]);
                        }
                    }
                }
                else if (info[0] == "Insert")
                {
                    nums.Insert(int.Parse(info[2]),int.Parse(info[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
