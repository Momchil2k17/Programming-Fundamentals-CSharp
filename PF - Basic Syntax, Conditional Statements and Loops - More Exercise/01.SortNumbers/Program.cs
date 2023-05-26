using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue; 
            int between = 0; 
            for (int num = 1; num <= 3; num++)
            {
                if (thirdNum > max) max = thirdNum;
                if (secondNum > max) max = secondNum;
                if (firstNum > max) max = firstNum;

                if (thirdNum < min) min = thirdNum;
                if (secondNum < min) min = secondNum;
                if (firstNum < min) min = firstNum;

                if (firstNum == max && secondNum == min) between = thirdNum;
                if (firstNum == max && thirdNum == min) between = secondNum;

                if (secondNum == max && firstNum == min) between = thirdNum;
                if (secondNum == max && thirdNum == min) between = firstNum;

                if (thirdNum == max && firstNum == min) between = secondNum;
                if (thirdNum == max && secondNum == min) between = firstNum;
            }
            Console.WriteLine(max);
            Console.WriteLine(between);
            Console.WriteLine(min);
        }
    }
}
