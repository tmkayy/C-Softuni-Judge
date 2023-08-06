using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person one = new Person(); one.Name = "Peter"; one.Age = 20;
            Person two = new Person(); two.Name = "George"; two.Age = 18;
            Person three = new Person(); three.Name = "Jose"; three.Age = 43;
        }
    }
}
