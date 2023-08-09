using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n!=0)
            {
                int num = n % 10;
                if (num%2==0)
                {
                    sum += num;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int num = n % 10;
                if (num % 2 != 0)
                {
                    sum += num;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }

    }
}
