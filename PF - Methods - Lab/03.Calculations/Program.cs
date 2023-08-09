using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (method == "add")
                Add(a, b);
            else if (method == "multiply")
                Multiply(a, b);
            else if (method == "subtract")
                Subtract(a, b);
            else if (method == "divide")
                Divide(a, b);
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
