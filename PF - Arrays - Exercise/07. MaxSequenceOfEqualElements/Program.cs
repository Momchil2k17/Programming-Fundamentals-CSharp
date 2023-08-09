using System;

namespace _07._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');

            int bestCount = 0;
            string bestNum = string.Empty;

            for (int i = 0; i < arr1.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        if (count>bestCount)
                        {
                            bestCount = count;
                            bestNum = arr1[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNum+" ");
            }
        }
    }
}
