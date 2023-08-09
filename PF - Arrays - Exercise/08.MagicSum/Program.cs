using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] + arr1[j] == n )
                    {
                        Console.WriteLine(arr1[i] + " " + arr1[j]);
                    }
                }
            }
        }
    }
}
