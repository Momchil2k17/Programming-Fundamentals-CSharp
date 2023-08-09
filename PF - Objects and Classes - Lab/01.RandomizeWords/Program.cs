using System;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            Random rnd = new Random();
            for (int i = 0; i < input.Count(); i++)
            {
                string temp = input[i];
                int index = rnd.Next(0, input.Count());
                input[i]=input[index];
                input[index] = temp;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
