﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            for (int i = 0; i < nums.Count()-1; i++)
            {
                if (nums[i]==nums[i+1])
                {
                    nums[i] += nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i =-1;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
