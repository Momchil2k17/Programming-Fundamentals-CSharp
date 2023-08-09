using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            float timeL = 0;
            float timeR = 0;
            for (int i = 0; i < nums.Count / 2; ++i)
            {
                timeL += nums[i];
                if (nums[i] == 0)
                {
                    timeL *= 0.8f;
                }
            }
            for (int i = nums.Count - 1; i > nums.Count / 2; --i)
            {
                timeR += nums[i];
                if (nums[i] == 0)
                {
                    timeR *= 0.8f;
                }
            }
            if (timeL < timeR)
            {
                Console.WriteLine($"The winner is left with total time: {timeL}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeR}");
            }
        }
    }
}
