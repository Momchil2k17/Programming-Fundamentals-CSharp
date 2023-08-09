using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();
            PrintRes(type, value);
        }
        static void PrintRes(string type, string value)
        {
            if (type == "int")
            {
                int n = int.Parse(value);
                Console.WriteLine(n * 2);
            }
            else if (type == "real")
            {
                double n = double.Parse(value);
                Console.WriteLine($"{n * 1.5:f2}");
            }
            else if (type == "string")
            {
                Console.WriteLine("$" + value + "$");
            }
        }
    }
}
