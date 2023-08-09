using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nums = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> nums2 = new List<int>();
            foreach (string numbers in nums)
            {
                nums2.AddRange(numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", nums2));
        }
    }
}
