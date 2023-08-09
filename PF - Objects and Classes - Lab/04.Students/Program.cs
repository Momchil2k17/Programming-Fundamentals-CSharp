using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command!="end")
            {
                string[] info = command.Split(" ").ToArray();
                Student student = new Student(info[0], info[1], int.Parse(info[2]), info[3]);
                students.Add(student);
                command = Console.ReadLine();
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (city==student.Town)
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
