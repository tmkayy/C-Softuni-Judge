using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    public class Rebel:IBuyer
    {
        string name;
        int age;
        string group;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Group { get => group; set => group = value; }
        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
