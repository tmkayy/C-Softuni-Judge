using System;
using System.Collections.Generic;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command.Length == 1)
                {
                    break;
                }
                bool OK = true;
                Person p = new Person(command[0], command[1], int.Parse(command[2]));
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Id==p.Id)
                    {
                        people[i].Name = p.Name;
                        people[i].Age = p.Age;
                        OK = false;
                        break;
                    }
                }
                if (OK)
                {
                    people.Add(p);
                }
            }
            foreach (Person person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        string name;
        string id;
        int age;
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
