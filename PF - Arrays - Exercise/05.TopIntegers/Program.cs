using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isGreater = true;
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i]<=arr1[j])
                    {
                        isGreater = false;
                    }
                }
                if (isGreater)
                {
                    Console.Write(arr1[i]+" ");
                }
            }
            
        }
    }
}
