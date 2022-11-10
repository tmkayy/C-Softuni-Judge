using System;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(lol);
            Console.WriteLine(String.Join(" ", lol));
        }
    }
}
