using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            int count = nums.Count();
            for (int i = 0; i < count / 2; i++)
            {
                nums[i] +=nums[nums.Count-1];
                nums.RemoveAt(nums.Count- 1);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
