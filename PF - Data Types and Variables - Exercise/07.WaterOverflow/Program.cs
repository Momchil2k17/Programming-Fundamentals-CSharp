using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfLitres = 0;
            for (int i = 0; i < n; i++)
            {
                int addLitres = int.Parse(Console.ReadLine());
                if (sumOfLitres+addLitres>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumOfLitres += addLitres;
                }
            }
            Console.WriteLine(sumOfLitres);
        }
    }
}
