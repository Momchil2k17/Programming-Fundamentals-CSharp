using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(double)(pounds * 1.31):f3}");
        }
    }
}
