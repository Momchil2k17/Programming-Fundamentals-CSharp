using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double dispalyPrice = double.Parse(Console.ReadLine());

            int hC = 0, mC = 0, kC = 0, dC = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i%6==0)
                {
                    hC++;
                    mC++;
                    kC++;
                }
                else if (i % 2 == 0)
                {
                    hC++;
                }
                else if (i % 3 == 0)
                {
                    mC++;
                }
                
            }
            double expenses = headsetPrice * hC + mousePrice * mC + keyboardPrice * kC + dispalyPrice * (kC/2);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
