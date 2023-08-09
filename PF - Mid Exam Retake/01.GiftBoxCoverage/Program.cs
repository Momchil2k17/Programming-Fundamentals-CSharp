using System;

namespace _01.GiftBoxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal sideSize = decimal.Parse(Console.ReadLine());
            decimal area = sideSize * sideSize * 6m;
            int sheetsCount = int.Parse(Console.ReadLine());
            decimal covered = 0;
            for (int i = 1; i <= sheetsCount; i++)
            {
                decimal length = decimal.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                decimal sheetArea = length * width;
                if (i % 3 == 0)
                {
                    covered += sheetArea * 0.75m;
                }
                else if (i % 5 != 0)
                {
                    covered += sheetArea;
                }
            }
            if (covered >= area)
            {
                Console.WriteLine($"You've covered the gift box!");
                decimal paperLeft = covered - area;
                if (covered==0)
                {
                    Console.WriteLine($"{0:F2}% wrap paper left.");
                }
                else
                {
                decimal percentageLeft = (paperLeft / covered) * 100m;
                Console.WriteLine($"{percentageLeft:F2}% wrap paper left.");
                }
               
            }
            else
            {
                decimal uncovered = ((area - covered) / area) * 100m;
                Console.WriteLine("You are out of paper!");
                Console.WriteLine($"{uncovered:f2}% of the box is not covered.");
            }
        }
    }
}
