using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //common hris L
            int n = int.Parse(Console.ReadLine());
            List<string> a = new List<string>();
            List<string> d = new List<string>();
            int ac = 0;
            int dc = 0;
            Regex regex = new Regex(@".*?@(?<name>[A-Z][a-z]+)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<type>A|D)![^@\-!:>]*?->(?<sol>\d+)");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                int c = s.Count(x=>x=='s'|| x == 't' || x == 'a' || x == 'r' || x == 'S' || x == 'T' || x == 'A' || x == 'R');
                var sb = new StringBuilder();
                for (int j = 0; j < s.Length; j++)
                {
                    sb.Append((char)(s[j]-c));
                }
                Match match = regex.Match(sb.ToString());
                if (match.Success)
                {
                    if (match.Groups["type"].ToString()=="A")
                    {
                        a.Add(match.Groups["name"].ToString());
                        ac++;
                    }
                    else if (match.Groups["type"].ToString() == "D")
                    {
                        d.Add(match.Groups["name"].ToString());
                        dc++;
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {ac}");
            foreach (var item in a.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {dc}");
            foreach (var item in d.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
