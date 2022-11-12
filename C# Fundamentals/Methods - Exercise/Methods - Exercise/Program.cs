using System;

namespace Methods___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Min(a, b, c);
        }
        static void Min(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        }
    }
}
