using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MagicCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();
            newDeck.Reverse();
            string command = Console.ReadLine();
            while (command!="Ready")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0]=="Add")
                {
                    string cardName = info[1];
                    if (deck.Contains(cardName))
                    {
                        newDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (info[0]=="Insert")
                {
                    string cardName = info[1];
                    int index = int.Parse(info[2]);
                    if (deck.Contains(cardName) && index>=0 && index<=newDeck.Count)//check
                    {
                        newDeck.Insert(index,cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (info[0]=="Remove")
                {
                    string cardName = info[1];
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.RemoveAll(x=>x==cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (info[0]=="Swap")
                {
                    string first = info[1];
                    string second = info[2];
                    for (int i = 0; i < newDeck.Count; i++)
                    {
                        if (newDeck[i]==first)
                        {
                            newDeck[i] = second;
                        }
                        else if (newDeck[i]==second)
                        {
                            newDeck[i] = first;
                        }
                    }
                }
                else if (info[0] == "Shuffle" && info[1]=="deck")
                {
                    newDeck.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",newDeck));
        }
    }
}
