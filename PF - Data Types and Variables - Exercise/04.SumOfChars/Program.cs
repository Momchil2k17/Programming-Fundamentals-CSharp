﻿using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
