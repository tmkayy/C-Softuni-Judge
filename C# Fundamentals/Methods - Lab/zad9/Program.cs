using System;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(Greater(a, b));
                    }
                    break;
                case "char":
                    {
                        char a = char.Parse(Console.ReadLine());
                        char b = char.Parse(Console.ReadLine());
                        Console.WriteLine(Greater(a, b));
                    }
                    break;
                case "string":
                    {
                        string a = Console.ReadLine();
                        string b = Console.ReadLine();
                        Console.WriteLine(Greater(a, b));
                    }
                    break;
            }
        }
        static int Greater(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char Greater(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string Greater(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
