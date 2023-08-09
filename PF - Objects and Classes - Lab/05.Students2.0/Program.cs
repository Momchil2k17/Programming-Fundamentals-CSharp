using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] info = command.Split(" ").ToArray();
                Student student = students.FirstOrDefault(x => x.FirstName == info[0] && x.LastName == info[1]);
                if (student==null)
                {
                    students.Add(new Student(info[0], info[1], int.Parse(info[2]), info[3]));
                }
                else
                {
                    student.Town = info[3];
                    student.Age = int.Parse(info[2]);
                }
                command = Console.ReadLine();
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (city == student.Town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}
