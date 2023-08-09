using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNums(n);
        }
        static void PrintTopNums(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsDivisibleBy8(i) && HoldsOddNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsDivisibleBy8(int n)
        {
            int sum = 0;
            bool isValid = false;
            while (n!=0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum%8==0)
            {
                isValid = true;
            }
            return isValid;
        }
        static bool HoldsOddNum(int n)
        {
            bool isValid = false;
            while (n != 0)
            {
                if ((n%10)%2!=0)
                {
                    isValid = true;
                }
                n /= 10;
            }
            return isValid;
        }
    }
}
