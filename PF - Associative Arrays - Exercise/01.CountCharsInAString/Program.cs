using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            var dictionary = new Dictionary<char, int>();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!dictionary.ContainsKey(word[i]))
                    {
                        dictionary[word[i]] = 0;
                    }
                    dictionary[word[i]]++;
                }
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
