using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(String.Join("\n", names.Distinct()));
        }
    }
}
