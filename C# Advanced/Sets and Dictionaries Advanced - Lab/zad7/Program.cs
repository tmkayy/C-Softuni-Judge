using System;
using System.Collections.Generic;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> lot = new HashSet<string>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(", ");
                if (s[0]=="END")
                {
                    if (lot.Any())
                    {
                        Console.WriteLine(string.Join("\n", lot));
                    }
                    else
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }
                    return;
                }
                else if (s[0]=="IN")
                {
                    lot.Add(s[1]);
                }
                else
                {
                    lot.Remove(s[1]);
                }
            }
        }
    }
}
