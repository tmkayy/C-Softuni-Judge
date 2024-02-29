using System;
using System.Collections.Generic;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Idshit> list = new List<Idshit>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0]=="End")
                {
                    string fc = Console.ReadLine();
                    list.ForEach(x => x.FakeCheck(fc));
                    return;
                }
                if (s.Length==3)
                {
                    var c = new Citizen(s[0], int.Parse(s[1]), s[2]);
                    list.Add(c);
                }
                else
                {
                    var r = new Robot(s[0], s[1]);
                    list.Add(r);
                }
            }
        }
    }
}
