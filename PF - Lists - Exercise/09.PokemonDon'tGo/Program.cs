using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int sum = 0;
            while (nums.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removeNum = 0;
                if (index < 0)
                {
                    nums.Insert(1, nums[nums.Count - 1]);
                    removeNum = nums[0];
                    nums.RemoveAt(0);
                }
                else if (index >= nums.Count)
                {
                    nums.Insert(nums.Count - 1, nums[0]);
                    removeNum = nums[nums.Count-1];
                    nums.RemoveAt(nums.Count - 1);
                }
                else
                {
                    removeNum = nums[index];
                    nums.RemoveAt(index);
                }
                sum += removeNum;
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= removeNum)
                    {
                        nums[i] += removeNum;
                    }
                    else
                    {
                        nums[i] -= removeNum;
                    }
                }
              
            }
            Console.WriteLine(sum);
        }
    }
}
