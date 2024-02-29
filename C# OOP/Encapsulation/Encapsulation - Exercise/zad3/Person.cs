using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Person
    {
        string name;
        double money;
        List<string> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<string>();
        }

        public string Name { get => name; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Money { get => money; set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
               money= value;
            }
        }
        public List<string> Bag { get => bag; set => bag = value; }

        public void Add2Bag(Product prod)
        {
            if (prod.Cost<=Money)
            {
                Money -= prod.Cost;
                bag.Add(prod.Name);
                Console.WriteLine($"{Name} bought {prod.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {prod.Name}");
            }
        }
    }
}
