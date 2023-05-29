using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int n = int.Parse(Console.ReadLine())-1;
            if (n >= 0 && n < daysOfWeek.Length)
                Console.WriteLine(daysOfWeek[n]);
            else
                Console.WriteLine("Invalid day!");
            
        }
    }
}
