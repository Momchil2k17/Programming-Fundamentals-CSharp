using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries*100;
            double days = Math.Floor(years * 365.2422);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {days*24} hours = {days*24*60} minutes");

        }
    }
}
