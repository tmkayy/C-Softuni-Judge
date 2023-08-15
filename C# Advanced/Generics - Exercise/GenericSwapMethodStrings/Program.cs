using System;
using System.Collections.Generic;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box b = new Box();
            var l = new List<string>();
            for (int i = 0; i < n; i++)
            {
                l.Add(Console.ReadLine());
            }
            string[] s = Console.ReadLine().Split(' ');
            b.Swap(l, int.Parse(s[0]), int.Parse(s[1]));
            l.ForEach(x=>Console.WriteLine(x.GetType()+": " + x));
        }
    }
}
