using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(DoThing(text, n));
        }
        static string DoThing(string text, int n)
        {
            string final = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                final += text;
            }
            return final;
        }
    }
}
