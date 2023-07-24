using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shit = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int>n = new List<int>();
            for (int i = int.Parse(shit[0]); i <= int.Parse(shit[1]); i++)
            {
                n.Add(i);
            }
            Predicate<int> odd = (a) => a % 2 == 1;
            Predicate<int> even = (a) => a % 2 == 0;
            string s = Console.ReadLine();
            Console.WriteLine(String.Join(" ", (s == "odd") ? n.FindAll(x => odd(Math.Abs(x))) : n.FindAll(x => even(Math.Abs(x)))));
        }
    }
}
