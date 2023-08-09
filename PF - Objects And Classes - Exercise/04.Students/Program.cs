using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                students.Add(new Student(info[0],info[1],decimal.Parse(info[2])));
            }
            foreach (Student student in students.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }
    }
}
