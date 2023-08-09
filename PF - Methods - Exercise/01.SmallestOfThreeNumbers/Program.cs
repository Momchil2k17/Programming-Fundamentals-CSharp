using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            PrintSmallest(n1, n2, n3);
        } 
        static void PrintSmallest(int n1,int n2,int n3)
        {
            int[] arr = { n1, n2, n3 };
            Array.Sort(arr);
            Console.WriteLine(arr[0]);
        }
    }
}
