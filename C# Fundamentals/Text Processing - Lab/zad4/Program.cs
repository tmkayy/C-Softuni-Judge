using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ");
            string s = Console.ReadLine();
            for (int i = 0; i < banned.Length; i++)
            {
                s = s.Replace(banned[i], new string('*', banned[i].Length));
            }
            Console.WriteLine(s);
        }
    }
}
