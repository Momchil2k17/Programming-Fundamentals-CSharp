using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (num!=0)
                {
                    sum +=num%10;
                    num /= 10;
                }
                bool special = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
