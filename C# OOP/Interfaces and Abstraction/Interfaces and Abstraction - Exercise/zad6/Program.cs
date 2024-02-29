using System;
using System.Collections.Generic;
using System.Linq;
using zad6;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listc = new List<Citizen>();
            var listr = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s.Length==4)
                {
                    var c = new Citizen(s[0], int.Parse(s[1]), s[2], s[3]);
                    listc.Add(c);
                }
                else
                {
                    var r = new Rebel(s[0], int.Parse(s[1]), s[2]);
                    listr.Add(r);
                }
            }
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "End") 
                {
                    Console.WriteLine(listc.Sum(x=>x.Food)+ listr.Sum(x => x.Food));
                    return;
                }
                foreach (var item in listc)
                {
                    if (item.Name==s)
                    {
                        item.BuyFood();
                    }
                }
                foreach (var item in listr)
                {
                    if (item.Name == s)
                    {
                        item.BuyFood();
                    }
                }
            }
        }
    }
}
