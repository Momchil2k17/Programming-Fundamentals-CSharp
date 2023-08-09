using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestArray = new int[n];
            string input = Console.ReadLine();
            int bestCount = 0, bestIndex = int.MaxValue, bestSum = 0, bestSequenceIndex = 0;
            int arrCount = 1;
            string[] separator = { "!" };
            while (input != "Clone them!")
            {
                int[] arr1 = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int arrSum = arr1.Sum();
                if (n==1)
                {
                    bestSum = 1;
                    bestSequenceIndex = arrCount;
                    bestArray = arr1;
                    break;
                }
                for (int i = 0; i < arr1.Length; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr1.Length; j++)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            count++;
                            if (count > bestCount && i < bestIndex)
                            {
                                bestCount = count;
                                bestIndex = i;
                                bestSum = arrSum;
                                bestSequenceIndex = arrCount;
                                bestArray = arr1;
                            }
                            else if (count==bestCount)
                            {
                                if (i<bestIndex)
                                {
                                    bestCount = count;
                                    bestIndex = i;
                                    bestSum = arrSum;
                                    bestSequenceIndex = arrCount;
                                    bestArray = arr1;
                                }
                                if (arrSum>bestSum)
                                {
                                    bestCount = count;
                                    bestIndex = i;
                                    bestSum = arrSum;
                                    bestSequenceIndex = arrCount;
                                    bestArray = arr1;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                arrCount++;
                input = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestArray));
        }
    }
}

