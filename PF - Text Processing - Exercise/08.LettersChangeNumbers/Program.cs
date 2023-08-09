using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { " " };
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double totalSum = 0;
            foreach (string word in input)
            {
                double num = int.Parse(word.Substring(1, word.Length - 2));
                char first = word[0];
                char last = word[word.Length - 1];
                if (char.IsUpper(first))
                {
                    int position = first - 'A' + 1;
                    num /= position;
                }
                else
                {
                    int position = first - 'a' + 1;
                    num *= position;
                }
                if (char.IsUpper(last))
                {
                    int position = last - 'A' + 1;
                    num -= position;
                }
                else
                {
                    int position = last - 'a' + 1;
                    num += position;
                }
                totalSum += num;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
