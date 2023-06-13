using System;
using System.Collections.Generic;
using System.Drawing;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            while (true)
            {
                string s =Console.ReadLine();
                if (s == "End")
                {
                    Console.WriteLine($"{q.Count} people remaining.");
                    return;
                }
                else if (s =="Paid")
                {
                    foreach (var item in q)
                    {
                        Console.WriteLine(item);
                    }
                    q.Clear();
                }
                else
                {
                    q.Enqueue(s);
                }
            }
        }
    }
}
