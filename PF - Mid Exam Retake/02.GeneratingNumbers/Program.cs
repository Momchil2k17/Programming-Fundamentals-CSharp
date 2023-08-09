using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GeneratingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] info = command.Split(" ").ToArray();
                if (info[0]=="replace")
                {
                    string values = command.Substring(8);
                    List<int> valuesToCheck = values.Split(" ").Select(int.Parse).ToList();
                    int value = valuesToCheck[0];
                    int replacement = valuesToCheck[1];
                    if (nums.Contains(value))
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i]==value)
                            {
                                nums[i] = replacement;
                                break;
                            }
                        }
                    }
                }
                else if (info[0] == "find" && info[1]=="odd")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (info[0] == "find" && info[1]=="even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]%2==0)
                        {
                            Console.Write(nums[i]+" ");
                        }
                    }
                    Console.WriteLine();
                }
                
                else if (info[0] == "add")
                {
                    string toAdd = command.Substring(13);
                    List<int> numsToAdd = toAdd.Split(" ").Select(int.Parse).ToList();
                    for (int i = numsToAdd.Count - 1; i >= 0; i--)
                    {
                        nums.Insert(0, numsToAdd[i]);
                    }
                }
                else if (info[0] == "remove" && info[1]=="at")
                {
                    int index = int.Parse(command.Substring(16));
                    if (index>=0 && index<nums.Count)
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (info[0] == "remove" && info[1]=="greater")
                {
                    int value = int.Parse(command.Substring(20));
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]>value)
                        {
                            nums.RemoveAt(i);
                            i--;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
