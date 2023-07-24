using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Action<string> print = (a) => Console.WriteLine(a);
            names.ForEach(x => print(x));
        }
    }
}
