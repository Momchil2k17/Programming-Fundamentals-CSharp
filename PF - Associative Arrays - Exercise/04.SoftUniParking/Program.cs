using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                if (info[0]=="register")
                {
                    string username = info[1];
                    string licensePlate = info[2];
                    if (dictionary.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dictionary[username]}");
                    }
                    else
                    {
                        dictionary[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                else if (info[0]=="unregister")
                {
                    string username = info[1];
                    if (dictionary.ContainsKey(username))
                    {
                        dictionary.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
