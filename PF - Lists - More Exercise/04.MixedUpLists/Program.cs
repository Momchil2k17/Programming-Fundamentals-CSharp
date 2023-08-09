using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            List<int> mix = new List<int>();
            if (list1.Count < list2.Count)
            {
                List<int> temp = list1;
                list1 = list2;
                list2 = temp;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j <list2.Count; j++)
                {
                    mix.Add(list1[i]);
                    i++;
                    mix.Add(list2[j]);
                }
                break;
            }

            int skip1 = list1[list1.Count-2];
            int skip2 = list1[list1.Count - 1];

            List<int> result = new List<int>();

            for (int i = 0; i < mix.Count; i++)
            {
                if (mix[i] > skip1 && mix[i] < skip2 || mix[i] < skip1 && mix[i] > skip2)
                    result.Add(mix[i]);
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
