using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += arr1[j];
                }
                for (int k = i+1; k < arr1.Length; k++)
                {
                    rightSum += arr1[k];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
