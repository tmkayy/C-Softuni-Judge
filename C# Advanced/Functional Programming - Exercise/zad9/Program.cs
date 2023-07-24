using System;
using System.Collections.Generic;
using System.Linq;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> riajuu = Console.ReadLine().Split(' ').ToList();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Party!")
                { Console.WriteLine(riajuu.Any() ? String.Join(", ", riajuu) + " are going to the party!" : "Nobody is going to the party!"); return; }
                else
                    riajuu = GO_EXPLODE(riajuu, s);
            }
        }
        static Func<List<string>, string[], List<string>> GO_EXPLODE = (l, s) =>
        {
            if (s[0] == "Remove")
            {
                l.RemoveAll(cond(s[1], s[2]));
            }
            else
            {
                List<string> temp = l.FindAll(cond(s[1], s[2]));
                int i = l.FindIndex(cond(s[1], s[2]));
                try
                {
                    l.InsertRange(i, temp);
                }
                catch { }
            }
            return l;
        };
        static Predicate<string> cond(string s, string currshit)
        {
            switch (s)
            {
                case "StartsWith":
                    return x => x.StartsWith(currshit);
                case "EndsWith":
                    return x => x.EndsWith(currshit);
                default:
                    return x => x.Length == int.Parse(currshit);
            }
        }
    }
}
