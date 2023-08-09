using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int special = bombInfo[0];
            int power = bombInfo[1];
            int indexOfBomb = 0;

            while (nums.Contains(special))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == special)
                    {
                        indexOfBomb = i;
                        break;
                    }
                }

                int startIndex = indexOfBomb - power;
                int count = 2 * power + 1;

                if (startIndex < 0)
                    startIndex = 0;

                if (count > nums.Count - 1)
                    count = nums.Count - startIndex;

                nums.RemoveRange(startIndex, count);
            }
            Console.WriteLine(nums.Sum());

        }
    }
}
