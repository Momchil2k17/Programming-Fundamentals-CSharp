﻿using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(removeWord))
            {
               text= text.Remove(text.IndexOf(removeWord),removeWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}
