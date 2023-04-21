using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                int x = s[i] + 3;
                Console.Write((char)x);
            }
        }
    }
}
