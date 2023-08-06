using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family f = new Family(new System.Collections.Generic.List<Person>());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Person p = new Person(s[0], int.Parse(s[1]));
                f.AddMember(p);
            }
            Console.WriteLine(f.GetOldestMember().Name +" "+ f.GetOldestMember().Age);
        }
    }
}
