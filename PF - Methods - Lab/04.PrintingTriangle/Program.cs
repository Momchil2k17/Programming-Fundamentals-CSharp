﻿using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void PrintRow(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintRow(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(1, i);
            }
        }
    }
}
