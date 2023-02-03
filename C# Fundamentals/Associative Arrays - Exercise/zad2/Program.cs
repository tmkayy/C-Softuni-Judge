using System;
using System.Collections.Generic;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "stop")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(s))
                {
                    resources[s] += n;
                }
                else
                {
                    resources.Add(s, n);
                }
            }
            foreach (KeyValuePair<string, int> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
