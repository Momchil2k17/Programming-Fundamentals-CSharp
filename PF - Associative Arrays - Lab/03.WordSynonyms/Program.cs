using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!dictionary.ContainsKey(key))
                {
                   dictionary[key]=new List<string>();
                }
                dictionary[key].Add(value);
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ",kvp.Value)}");
            }
        }
        //{string.Join(",",kvp.Value)
    }
}
