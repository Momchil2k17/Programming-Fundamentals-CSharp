using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            int[] bugsIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < bugsIndex.Length; i++)
            {
                int index = bugsIndex[i];
                if (index>=0 && index<field.Length)
                {
                    field[index] = 1;
                }
            }
            string command ="";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command.Split(' ').ToArray();
                int currentIndex = int.Parse(info[0]);
                string direction = info[1];
                int flyLength = int.Parse(info[2]);
                if (currentIndex < 0 || currentIndex > field.Length - 1 || field[currentIndex]==0)
                {
                    continue;
                }
                field[currentIndex] = 0;
                if (direction == "right")
                {
                    int landIndex = currentIndex + flyLength;
                    if (landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if (field[landIndex]==1)
                    {
                        while (field[landIndex]==1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex<field.Length)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = currentIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 )
                    {
                        field[landIndex] = 1;
                    }

                }
            }

            Console.WriteLine(string.Join(' ', field));

        }
    }
}
