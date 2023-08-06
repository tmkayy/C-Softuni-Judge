using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> f = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Person p = new Person(s[0], int.Parse(s[1]));
                f.Add(p);
            }
            foreach (var item in f.Where(x=>x.Age>30).OrderBy(x=>x.Name))
                Console.WriteLine(item.Name + " - " + item.Age);
        }
    }
}
