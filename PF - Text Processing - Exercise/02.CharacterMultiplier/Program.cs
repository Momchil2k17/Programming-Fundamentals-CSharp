using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            int length = Math.Max(words[0].Length, words[1].Length);
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (i < words[0].Length && i < words[1].Length)
                {
                    sum += ((char)words[0][i] * (char)words[1][i]);
                }
                else if (i < words[0].Length)
                {
                    sum += (char)words[0][i];
                }
                else if (i < words[1].Length)
                {
                    sum += (char)words[1][i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
