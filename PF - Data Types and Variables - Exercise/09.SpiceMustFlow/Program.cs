using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCount = 0, totalSpice = 0;
            while (yield >= 100)
            {
                dayCount++;
                totalSpice += (yield - 26);
                yield -= 10;
            }
            if (totalSpice>=26)
            {
                totalSpice -= 26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(totalSpice);
        }
    }
}
