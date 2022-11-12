using System;

namespace Methods___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Check(a);
        }
        static void Check(int a)
        {
            if (a>0)
            {
                Console.WriteLine($"The number {a} is positive. ");
            }
            else if (a==0)
            {
                Console.WriteLine($"The number {a} is zero. ");
            }
            else
            {
                Console.WriteLine($"The number {a} is negative. ");
            }
        }
    }
}
