using System;

namespace _06.TriplesОfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)(97+i)}{(char)(97 + j)}{(char)(97 + k)}");
                    }
                }
            }
        }
    }
}
