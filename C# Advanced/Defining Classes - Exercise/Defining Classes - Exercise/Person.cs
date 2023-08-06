using System;

namespace DefiningClasses
{
    public class Person
    {
        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
