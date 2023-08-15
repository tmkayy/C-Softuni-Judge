using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box b = new Box();
            var list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(b.Greater(list, double.Parse(Console.ReadLine())));
        }
    }
}
