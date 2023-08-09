using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Trib(n);
        }
        static void Trib(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 2;
            int m = 0;
            if (n == 1)
            {
                Console.Write(1 + " ");
            }
            else if (n == 2)
            {
                Console.Write(1 + " " + 1 + " ");
            }
            else if (n == 3)
            {
                Console.Write(1 + " " + 1 + " " + 2 + " ");
            }
            else
            {
                Console.Write(1 + " " + 1 + " " + 2 + " ");

                for (int i = 0; i < n - 3; i++)
                {
                    m = num1 + num2 + num3;
                    num1 = num2;
                    num2 = num3;
                    num3 = m;
                    Console.Write(m + " ");

                }
            }
        }
    }
}
