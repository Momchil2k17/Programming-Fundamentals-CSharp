using System;
using System.Linq;

namespace _01.Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = "";
            while ((command=Console.ReadLine()) != "Abracadabra")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0] == "Abjuration")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (info[0] == "Necromancy")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (info[0] == "Illusion")
                {
                    int index = int.Parse(info[1]);
                    if (index >= 0 && index < input.Length)
                    {
                        char letter = char.Parse(info[2]);
                        string currentWord = "";
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i == index)
                            {
                                currentWord += letter;
                            }
                            else
                            {
                                currentWord += input[i];
                            }
                        }
                        input = currentWord;
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (info[0] == "Divination")
                {
                    string first = info[1];
                    string second = info[2];
                    if (input.Contains(first))
                    {
                        input = input.Replace(first, second);
                    }
                    else
                    {
                        continue;
                    }
                    Console.WriteLine(input);
                }
                else if (info[0] == "Alteration")
                {
                    string first = info[1];
                    if (input.Contains(first))
                    {
                        input = input.Remove(input.IndexOf(first),first.Length);
                    }
                    else
                    {
                        continue;
                    }
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
