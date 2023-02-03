using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string s1 = Console.ReadLine();
                double s2 = double.Parse(Console.ReadLine());
                if (students.ContainsKey(s1))
                {
                    students[s1].Add(s2);
                }
                else
                {
                    List<double> grades = new List<double>();
                    grades.Add(s2);
                    students.Add(s1, grades);
                }
            }
            foreach (KeyValuePair<string, List<double>> entry in students.Where(x => x.Value.Sum() / x.Value.Count >= 4.5))
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value.Sum()/entry.Value.Count:f2}");
            }
        }
    }
}
