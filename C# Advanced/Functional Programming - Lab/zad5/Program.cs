using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<List<Person>, int, List<Person>> readppl = (a, n) =>
            {
                for (int i = 0; i < n; i++)
                {
                    string[] s = Console.ReadLine().Split(", ");
                    Person p = new Person(s[0], int.Parse(s[1]));
                    a.Add(p);
                }
                return a;
            };
            List<Person> ppl = new List<Person>();
            ppl = readppl(ppl, n);
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> filter = FILTEREDANDOWNED(condition, age);
            Action<List<Person>, Func<Person, bool>, string> print = (ppl, filter, format) =>
            {
                if (format=="name")
                {
                    Console.WriteLine(String.Join(Environment.NewLine, ppl.Where(filter).Select(p=>p.Name)));
                }
                else if (format=="age")
                {
                    Console.WriteLine(String.Join(Environment.NewLine, ppl.Where(filter).Select(p => p.Age)));
                }
                else
                {
                    ppl = ppl.Where(filter).ToList();
                    ppl.ForEach(p=>Console.WriteLine(p.Name+" - "+p.Age));
                }
            };
            print(ppl, filter, format);
        }
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
        }
        static Func<Person, bool> FILTEREDANDOWNED(string condition, int SHESAIDSHEWAS18) => (person) =>
        {
            switch (condition)
            {
                case "younger":
                    return person.Age < SHESAIDSHEWAS18;
                default:
                    return person.Age >= SHESAIDSHEWAS18;
            }
        };
    }
}
