using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s2 = Console.ReadLine();
            string s1 = Console.ReadLine();
            while (s1.Contains(s2))
            {
                s1 = s1.Replace(s2, "");
            }
            Console.WriteLine(s1);
        }
    }
}
