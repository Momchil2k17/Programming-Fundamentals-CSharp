using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int charStartIndex = int.Parse(Console.ReadLine());
            int charLastIndex = int.Parse(Console.ReadLine());
            for (int i = charStartIndex; i <= charLastIndex; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol+" ");
            }
        }
    }
}
