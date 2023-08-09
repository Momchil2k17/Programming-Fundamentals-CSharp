using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] info = command.Split(" ").ToArray();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                Person findPerson = persons.Find(v => v.ID == id);
                if (findPerson!=null)
                {
                    findPerson.Name = name;
                    findPerson.Age = age;
                }
                else
                {
                    persons.Add(new Person(name, id, age));
                }
                command = Console.ReadLine();
            }
            foreach (Person person in persons.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
