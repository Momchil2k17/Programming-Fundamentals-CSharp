using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= endNum; currentNum++)
            {
                bool isPrime = true;
                for (int divide = 2; divide < currentNum; divide++)
                {
                    if (currentNum % divide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNum, isPrime.ToString().ToLower());
            }

        }
    }
}
