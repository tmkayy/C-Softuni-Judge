using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //common hris L
            char[] c = { ',', ' '};
            List<string> demons = Console.ReadLine().Split(c, StringSplitOptions.RemoveEmptyEntries).ToList();
            Regex hp = new Regex(@"[^\d+\-*/\.]");
            Regex dmg = new Regex(@"[+-]?\d+\.\d+|[+-]?\d+");
            Regex xtra = new Regex(@"[/*]");
            for (int i = 0; i < demons.Count; i++)
            {
                int hpsum = 0;
                double dmgsum = 0;
                MatchCollection hpmatches = hp.Matches(demons[i]);
                foreach (Match match in hpmatches)
                {
                    hpsum += char.Parse(match.ToString());
                }
                MatchCollection dmgmatches = dmg.Matches(demons[i]);
                foreach (var item in dmgmatches)
                {
                    dmgsum+= double.Parse(item.ToString());
                }
                MatchCollection xtramatches = xtra.Matches(demons[i]);
                foreach(var item in xtramatches)
                {
                    if(item.ToString() == "/")
                    {
                        dmgsum /= 2;
                    }
                    if (item.ToString() == "*")
                    {
                        dmgsum *= 2;
                    }
                }
                string s = $"{demons[i]} - {hpsum} health, {dmgsum:f2} damage";
                demons[i] = s;
            }
            foreach (var item in demons.OrderBy(x=>x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
