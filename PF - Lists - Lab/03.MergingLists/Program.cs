using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums1 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> nums2 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> result = new List<double>();
            int bigerListCount = Math.Max(nums1.Count, nums2.Count);
            for (int i = 0; i < bigerListCount; i++)
            {
                if (nums1.Count>i)
                {
                    result.Add(nums1[i]);
                }                        
                if (nums2.Count > i)
                {
                    result.Add(nums2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
