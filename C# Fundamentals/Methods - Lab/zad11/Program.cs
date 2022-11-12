using System;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string znak = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Operation(a, b, znak));
        }
        static double Operation(double a, double b, string znak)
        {
            switch (znak)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                default:
                    return a / b;
            }
        }
    }
}
