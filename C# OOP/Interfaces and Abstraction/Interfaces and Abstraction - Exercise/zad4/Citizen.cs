using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Citizen:Idshit
    {
        string name;
        int age;

        public Citizen(string name, int age, string id):base(id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
