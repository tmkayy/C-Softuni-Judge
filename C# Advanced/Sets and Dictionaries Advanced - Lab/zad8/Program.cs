using System;
using System.Collections.Generic;
using System.Linq;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> VIP = new HashSet<string>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s=="PARTY")
                {
                    break;
                }
                if (s.Length==8)
                {
                    if (char.IsDigit(s[0]))
                    {
                        VIP.Add(s);
                    }
                    else
                    {
                        regular.Add(s);
                    }
                }
            }
            while (true)
            {
                string s = Console.ReadLine();
                if (s=="END")
                {
                    break;
                }
                if (VIP.Contains(s))
                {
                    VIP.Remove(s);
                }
                else if (regular.Contains(s))
                {
                    regular.Remove(s);
                }
            }
            Console.WriteLine(VIP.Count+regular.Count);
            if (VIP.Any())
            {
                Console.WriteLine(String.Join("\n", VIP));
            }
            if (regular.Any())
            {
                Console.WriteLine(String.Join("\n", regular));
            }
        }
    }
}
