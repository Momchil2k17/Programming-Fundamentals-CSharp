using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var dictionary = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]] = 0;
                }
                dictionary[numbers[i]]++;
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
