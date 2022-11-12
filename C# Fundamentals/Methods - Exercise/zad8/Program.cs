using System;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorials(a, b):f2}");
        }
        static double Factorials(int a, int b)
        {
            double factoriala = 1;
            double factorialb = 1;
            for (int i = 1; i <= a; i++)
            {
                factoriala *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                factorialb *= i;
            }
            return factoriala / factorialb;
        }
    }
}
