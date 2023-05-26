using System;

namespace _02.EnglishName
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastNum = n % 10;
            if (lastNum==0)
            {
                Console.WriteLine("zero");
            }
            else if (lastNum==1)
            {
                Console.WriteLine("one");
            }
            else if (lastNum == 2)
            {
                Console.WriteLine("two");
            }
            else if (lastNum == 3)
            {
                Console.WriteLine("three");
            }
            else if (lastNum == 4)
            {
                Console.WriteLine("four");
            }
            else if (lastNum == 5)
            {
                Console.WriteLine("five");
            }
            else if (lastNum == 6)
            {
                Console.WriteLine("six");
            }
            else if (lastNum == 7)
            {
                Console.WriteLine("seven");
            }
            else if (lastNum == 8)
            {
                Console.WriteLine("eight");
            }
            else if (lastNum == 9)
            {
                Console.WriteLine("nine");
            }

        }
    }
}
