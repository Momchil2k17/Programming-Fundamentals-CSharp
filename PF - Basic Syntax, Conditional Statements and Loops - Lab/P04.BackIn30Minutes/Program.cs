using System;

namespace P04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m += 30;
            if (m >= 60)
            {
                h++;
                m -= 60;
            }
            if (h>23)
            {
                h = 0;
            }
            Console.WriteLine($"{h}:{m:d2}");
        }
    }
}
