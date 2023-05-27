using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();
                long leftNum = long.Parse(nums.Substring(0, nums.IndexOf(" ")));
                long rightNum = long.Parse(nums.Substring(nums.IndexOf(" ")+1,nums.Length-1-nums.IndexOf(" ")));
                long sum = 0;
                if (rightNum<leftNum)
                {
                    while (leftNum!=0)
                    {
                        sum += (leftNum % 10);
                        leftNum /= 10;
                    }
                }
                else
                {
                    while (rightNum != 0)
                    {
                        sum += (rightNum % 10);
                        rightNum /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
