using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i+1!=numbers.Count)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
