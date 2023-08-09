using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string[] allWords = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < allWords.Count(); i++)
            {
                string current = allWords[i];
                string word = current.Substring(0, current.IndexOf(':'));
                string definitions = current.Substring(current.IndexOf(':') + 2);
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();
                }
                dictionary[word].Add(definitions);
            }
            string[] testWords = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = Console.ReadLine();
            if (command=="Test")
            {
                foreach (string testWord in testWords)
                {
                    if (dictionary.ContainsKey(testWord))
                    {
                        Console.WriteLine($"{testWord}:");
                        foreach (var kvp in dictionary[testWord])
                        {
                            Console.WriteLine($" -{kvp}");
                        }
                    }
                }
            }
            else if (command=="Hand Over")
            {
                foreach (var kvp in dictionary)
                {
                    Console.Write(kvp.Key+" ");
                }
            }
        }
    }
}
