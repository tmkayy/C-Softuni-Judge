using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (d.ContainsKey(num))
                {
                    d[num]++;
                }
                else
                {
                    d.Add(num, 1);
                }
            }
            Console.WriteLine(String.Join(string.Empty,d.Where(x=>x.Value%2==0).Select(x=>x.Key)));
        }
    }
}
