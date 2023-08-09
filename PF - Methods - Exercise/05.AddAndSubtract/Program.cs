using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Add(n1,n2),n3));
        }
        static int Add(int n1,int n2)
        {
            return n1 + n2;
        }
        static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

    }
}
