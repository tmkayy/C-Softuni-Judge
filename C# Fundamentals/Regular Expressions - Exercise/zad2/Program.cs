using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mems = Console.ReadLine().Split(", ").ToList();
            Regex w = new Regex(@"[A-Z]|[a-z]");
            Regex d = new Regex(@"\d");
            Dictionary<string, int> member = new Dictionary<string, int>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "end of race")
                { break; }
                StringBuilder sb = new StringBuilder();
                int sum = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (w.IsMatch(s[i].ToString()))
                    {
                        sb.Append(s[i]);
                    }
                    else if (d.IsMatch(s[i].ToString()))
                    {
                        sum += int.Parse(s[i].ToString());
                    }
                }
                if (member.ContainsKey(sb.ToString()))
                {
                    member[sb.ToString()] += sum;
                }
                else if (mems.Contains(sb.ToString())) 
                {
                    member[sb.ToString()] = sum;
                }
            }
            int count = 0;
            foreach (var item in member.OrderByDescending(x => x.Value))
            {
                count++;
                if (count==1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if(count==2) 
                {
                    Console.WriteLine($"2nd place: {item.Key}"); 
                }
                else
                { 
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }
        }
    }
}
