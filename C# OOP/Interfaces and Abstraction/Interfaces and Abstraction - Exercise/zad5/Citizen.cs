using System;
using System.Collections.Generic;
using System.Text;
using zad5;

namespace zad4
{
    public class Citizen : Idshit, Bdayy
    {
        string name;
        int age;
        string bday;

        public Citizen(string name, int age, string id, string bday) : base(id)
        {
            Name = name;
            Age = age;
            Id = id;
            Bday = bday;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Bday { get => bday; set => bday = value; }
    }
}
