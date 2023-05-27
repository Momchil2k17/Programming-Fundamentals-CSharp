using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0, bestSnowballTime = 0, bestSnowballQuality = 0;
            BigInteger highestValue=0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
                if (currentValue>highestValue)
                {
                    highestValue = currentValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestValue} ({bestSnowballQuality})");
        }
    }
}
