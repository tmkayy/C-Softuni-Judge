using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons  = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                var p = new Person(s[0], s[1], int.Parse(s[2]), decimal.Parse(s[3]));
                persons.Add(p);
            }
            decimal percentage = decimal.Parse(Console.ReadLine());
           persons.ForEach(p=>p.IncreaseSalary(percentage));
           persons.ForEach(Console.WriteLine);
        }
    }
}
