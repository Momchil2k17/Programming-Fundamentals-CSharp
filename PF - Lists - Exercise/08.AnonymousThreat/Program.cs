using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0] == "merge")
                {
                    int startIndex = int.Parse(info[1]);
                    int endIndex = int.Parse(info[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }
                    if (startIndex<input.Count && startIndex!=endIndex)
                    {
                    input = Merge(startIndex, endIndex, input);
                    }
                    
                }
                else if (info[0] == "divide")
                {
                    int index = int.Parse(info[1]);
                    int partitions = int.Parse(info[2]);
                    input=Divide(index, partitions, input);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
        static List<string> Merge(int startIndex, int endIndex, List<string> input)
        {
            string merged = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += input[i];
            }
            for (int i = 0; i <= endIndex - startIndex; i++)
            {
                input.RemoveAt(startIndex);
            }
            input.Insert(startIndex, merged);
            return input;
        }
        static List<string> Divide(int index, int partitions, List<string> input)
        {
            string word = input[index];
            string dividedWord = "";
            int normalWordLength = word.Length / partitions;
            int addLastWordLength = word.Length % partitions;
            for (int i = 0; i < partitions; i++)
            {
                if (i==partitions-1)
                {
                    normalWordLength += addLastWordLength;
                    dividedWord += word.Substring(0, normalWordLength);
                    break;
                }
                dividedWord += word.Substring(0, normalWordLength)+" ";
                word = word.Substring(normalWordLength, word.Length - normalWordLength);
            }
            input.RemoveAt(index);
            input.Insert(index, dividedWord);
            return input;

        }

    }
}
