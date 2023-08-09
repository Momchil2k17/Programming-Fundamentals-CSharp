using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintChars(start, end);
        }
        static void PrintChars(char start, char end)
        {
            char swap = ' ';
            if (end<start)
            {
                swap = start;
                start = end;
                end = swap;
            }
            for (int i = (int)start+1; i < (int)end; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
