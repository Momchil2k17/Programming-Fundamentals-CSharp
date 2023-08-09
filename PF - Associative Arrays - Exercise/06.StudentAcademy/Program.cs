using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(student))
                {
                    dictionary[student] = new List<decimal>();
                }
                dictionary[student].Add(grade);
            }
            foreach (var kvp in dictionary.Where(x=>x.Value.Average() >= 4.50m))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
