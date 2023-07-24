using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Action<string> print = (a) => Console.WriteLine("Sir " + a);
            names.ForEach(x => print(x));
        }
    }
}
