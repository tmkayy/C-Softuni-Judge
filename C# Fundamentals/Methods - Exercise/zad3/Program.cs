using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Dif(a, b);
        }
        static void Dif(char a, char b)
        {
            char x;
            if (a>b)
            {
                x = a;
                a = b;
                b = x;
            }
            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
