﻿using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input,count));
        }
        static string RepeatString(string input,int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
