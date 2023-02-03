using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> counts = new Dictionary<double, int>();
            foreach (double number in numbers) 
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else 
                {
                    counts.Add(number, 1);
                }
            }
            foreach (KeyValuePair<double, int> num in counts.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
