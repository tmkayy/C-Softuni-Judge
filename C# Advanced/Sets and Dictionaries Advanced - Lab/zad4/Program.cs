using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> markets = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(", ");
                if (s[0] == "Revision")
                {
                    foreach (var item in markets.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine($"{item.Key}->");
                        item.Value.ForEach(x => Console.WriteLine(x));
                    }
                    return;
                }
                if (!markets.ContainsKey(s[0]))
                {
                    markets.Add(s[0], new List<string> { $"Product: {s[1]}, Price: {double.Parse(s[2])}" });
                }
                else
                {
                    markets[s[0]].Add($"Product: {s[1]}, Price: {double.Parse(s[2])}");
                }
            }
        }
    }
}
