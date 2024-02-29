using System;
using System.Collections.Generic;
using zad5;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bdayy> list = new List<Bdayy>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0]=="End")
                {
                    string fc = Console.ReadLine();
                    list.ForEach(x => x.Birth(fc));
                    return;
                }
                if (s.Length==5)
                {
                    var c = new Citizen(s[1], int.Parse(s[2]), s[3], s[4]);
                    list.Add(c);
                }
                else if (s[0]=="Pet")
                {
                    var p = new Pet(s[1], s[2]);
                    list.Add(p);
                }
            }
        }
    }
}
