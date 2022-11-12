using System;
using System.Diagnostics.Tracing;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Palindrom(n);
        }
        static void Palindrom(string n)
        {
            while (true)
            {
                if (n=="END")
                {
                    return;
                }
                int x = int.Parse(n);
                int originalx = x;
                int rev = 0;
                while (x!=0)
                {
                    rev = rev * 10 + x % 10;
                    x /= 10;
                }
                if (originalx==rev)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                n = Console.ReadLine();
            }
        }
    }
}
