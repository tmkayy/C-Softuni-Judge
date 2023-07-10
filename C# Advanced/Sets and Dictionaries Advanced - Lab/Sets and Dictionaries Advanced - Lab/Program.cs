using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> count = new Dictionary<double, int>();
            foreach (var item in arr)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count.Add(item, 1);
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
