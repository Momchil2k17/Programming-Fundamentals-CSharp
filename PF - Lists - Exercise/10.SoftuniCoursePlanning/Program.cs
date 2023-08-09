using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduele = Console.ReadLine().Split(", ").ToList();

            string command = string.Empty;
            while (command!="course start")
            {
                string[] arguments = command.Split(":").ToArray();
                switch (arguments[0])
                {
                    case "Add":
                        scheduele = AddTitle(scheduele, arguments[1]);
                        break;
                    case "Insert":
                        scheduele = InsertTitle(scheduele, arguments[1],int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        scheduele = RemoveTitle(scheduele, arguments[1]);
                        break;
                    case "Swap":
                        scheduele = SwapTitle(scheduele, arguments[1], arguments[2]);
                        break;
                    case "Exercise":
                        scheduele = Exercise(scheduele, arguments[1]);
                        break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < scheduele.Count; i++)
            {
                Console.WriteLine($"{i+1}.{scheduele[i]}");
            }

        }

        private static List<string> Exercise(List<string> scheduele, string name)
        {
            string exercise = name + "-Exercise";
            if (scheduele.Contains(name) && !scheduele.Contains(exercise))
            {
                scheduele.Insert(scheduele.IndexOf(name) + 1, exercise);
            }
            else if (!scheduele.Contains(name))
            {
                scheduele.Add(name);
                scheduele.Add($"{name}-Exercise");
            }
            return scheduele;
        }

        private static List<string> SwapTitle(List<string> scheduele, string first, string second)
        {
            if (scheduele.Contains(first) && scheduele.Contains(second))
            {
                string firstEx = first + "-Exercise";
                string secondEx = second + "-Exercise";
                int firstIndex = scheduele.IndexOf(first);
                int secondIndex = scheduele.IndexOf(second);
                string temp1 = scheduele[firstIndex];
                scheduele[firstIndex] = scheduele[secondIndex];
                scheduele[secondIndex] = temp1;
                if (scheduele.Contains(firstEx) && scheduele.Contains(secondEx))
                {
                    string temp2 = scheduele[firstIndex + 1];
                    scheduele[firstIndex + 1] = scheduele[secondIndex + 1];
                    scheduele[secondIndex + 1] = temp2;
                }
                else if (scheduele.Contains(firstEx) && !scheduele.Contains(secondEx))
                {
                    scheduele.RemoveAt(firstIndex + 1);
                    scheduele.Insert(scheduele.IndexOf(first) + 1, firstEx);
                }
                else if (!scheduele.Contains(firstEx) && scheduele.Contains(secondEx))
                {
                    scheduele.RemoveAt(secondIndex + 1);
                    scheduele.Insert(scheduele.IndexOf(second) + 1, secondEx);
                }
            }
            return scheduele;
        }

        private static List<string> RemoveTitle(List<string> scheduele, string name)
        {
            string exercise = name + "-Exercise";
            if (scheduele.Contains(name))
            {
                scheduele.Remove(name);
            }
            if (scheduele.Contains(exercise))
            {
                scheduele.Remove(exercise);
            }
            return scheduele;
        }

        private static List<string> InsertTitle(List<string> scheduele, string name, int index)
        {
            if (scheduele.Contains(name) == false && index >= 0 && index < scheduele.Count)

            {
                scheduele.Insert(index, name);
            }
            return scheduele;
        }

        private static List<string> AddTitle(List<string> scheduele, string name)
        {
            if (scheduele.Contains(name)==false)
            {
                scheduele.Add(name);
            }
            return scheduele;
        }
    }
}