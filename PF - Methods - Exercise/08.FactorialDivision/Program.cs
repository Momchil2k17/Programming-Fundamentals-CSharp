using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorial(n1)/Factorial(n2):F2}");
        }
        static double Factorial(int n)
        {
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
