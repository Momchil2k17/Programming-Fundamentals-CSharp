using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddle(text);
        }
        static void PrintMiddle(string text)
        {
            int num = text.Length;
            if (num%2==0)
            {
                Console.WriteLine($"{text[num / 2 - 1]}{text[num / 2]}");
            }
            else
            {
                Console.WriteLine($"{text[num / 2]}");
            }
        }
    }
}
