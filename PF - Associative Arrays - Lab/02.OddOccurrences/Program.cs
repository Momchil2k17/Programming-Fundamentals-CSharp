using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(" ").ToArray();
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < words.Count(); i++)
            {
                if (!dictionary.ContainsKey(words[i]))
                {
                    dictionary[words[i]] = 0;
                }
                dictionary[words[i]]++;
            }
            foreach (var kvp in dictionary.Where(x=>x.Value%2!=0))
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}
