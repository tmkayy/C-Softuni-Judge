using System;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<char, bool> up = (c) => char.IsUpper(c);
            foreach (var item in s.Where(x => up(x[0])))
            {
                Console.WriteLine(item);
            }
        }
    }
}
