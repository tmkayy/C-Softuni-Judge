using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] jag = new List<int>[n];
            int prevl = 0;
            for (int i = 0; i < n; i++)
            {
                jag[i] = new List<int>();
                int[] lol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < lol.Length; j++)
                {
                    jag[i].Add(lol[j]);
                }
                if (lol.Length == prevl && i > 0)
                {
                    jag[i - 1] = jag[i - 1].Select(x => x * 2).ToList();
                    jag[i] = jag[i].Select(x => x * 2).ToList();
                }
                else if (lol.Length != prevl && i > 0&&prevl!=0)
                {
                    jag[i - 1] = jag[i - 1].Select(x => x / 2).ToList();
                    jag[i] = jag[i].Select(x => x / 2).ToList();
                }
                prevl= jag[i].Count;
            }
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] =="End")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, jag.Select(x => string.Join(' ', x))));
                    return;
                }
                else if (s[0]=="Add")
                {
                    try
                    {
                        jag[int.Parse(s[1])][int.Parse(s[2])] += int.Parse(s[3]);
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        jag[int.Parse(s[1])][int.Parse(s[2])] -= int.Parse(s[3]);
                    }
                    catch { }
                }
            }
        }
    }
}
