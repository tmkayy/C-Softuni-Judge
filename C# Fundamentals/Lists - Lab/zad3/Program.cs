using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> numbers3 = new List<double>();
            for (int i = 0; i < Math.Max(numbers.Count, numbers2.Count); i++)
            {
                if (i<numbers.Count)
                {
                    numbers3.Add(numbers[i]);
                }
                if (i < numbers2.Count)
                {
                    numbers3.Add(numbers2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", numbers3));
        }
    }
}
