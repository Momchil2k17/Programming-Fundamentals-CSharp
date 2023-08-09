using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool change = false;
            while (command!="end")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0] == "Add")
                {
                    nums.Add(int.Parse(info[1]));
                    change = true;
                }
                else if (info[0] == "Remove")
                {
                    nums.Remove(int.Parse(info[1]));
                    change = true;
                }
                else if (info[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(info[1]));
                    change = true;
                }
                else if (info[0] == "Insert")
                {
                    nums.Insert(int.Parse(info[2]), int.Parse(info[1]));
                    change = true;
                }
                else if (info[0]=="Contains")
                {
                    if (nums.Contains(int.Parse(info[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (info[0] == "PrintEven")
                {
                    PrintEven(nums);
                }
                else if (info[0] == "PrintOdd")
                {
                    PrintOdd(nums);
                }
                else if (info[0]=="GetSum")
                {
                    GetSum(nums);
                }
                else if (info[0]=="Filter")
                {
                    Filter(info[1], int.Parse(info[2]), nums);
                }
                command = Console.ReadLine();
            }
            if (change)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
        static void PrintEven(List<int> nums) 
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2==0)
                {
                    Console.Write(nums[i]+" ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void GetSum(List<int> nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
        static void Filter(string condition,int num, List<int> nums) 
        {
            if (condition=="<")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i]<num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (condition=="<=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] >= num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (condition == ">")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
