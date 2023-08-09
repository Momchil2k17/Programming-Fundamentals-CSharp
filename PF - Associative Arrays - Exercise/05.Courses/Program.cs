using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] info = command.Split(":").ToArray();
                string course = info[0].Substring(0, info[0].Length - 1);
                string student= info[1].Substring(1, info[1].Length - 1);
                if (!dictionary.ContainsKey(course))
                {
                    dictionary[course] = new List<string>();
                }
                dictionary[course].Add(student);
                command = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
