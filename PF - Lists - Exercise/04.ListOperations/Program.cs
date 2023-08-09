using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0] == "Add")
                {
                    nums.Add(int.Parse(info[1]));
                }
                else if (info[0] == "Remove")
                {
                    if (int.Parse(info[1]) < nums.Count && int.Parse(info[1]) >= 0)
                    {
                        nums.RemoveAt(int.Parse(info[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (info[0] == "Insert")
                {
                    if (int.Parse(info[2]) < nums.Count && int.Parse(info[2])>=0)
                    {
                        nums.Insert(int.Parse(info[2]), int.Parse(info[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (info[0] == "Shift")
                {
                    if (info[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(info[2]); i++)
                        {
                            int first = nums[0];
                            for (int j = 0; j < nums.Count - 1; j++)
                            {
                                nums[j] = nums[j + 1];
                            }
                            nums[nums.Count - 1] = first;
                        }
                    }
                    else if (info[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(info[2]); i++)
                        {
                            int last = nums[nums.Count - 1];
                            for (int j = nums.Count - 1; j >= 1; j--)
                            {
                                nums[j] = nums[j - 1];
                            }
                            nums[0] = last;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
