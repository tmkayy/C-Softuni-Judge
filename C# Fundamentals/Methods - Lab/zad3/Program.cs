using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(DoThing(operation, a, b));
        }
        static double DoThing(string operation, double a, double b)
        {
            switch (operation)
            {
                case "add":
                    return a + b;
                case "multiply":
                    return a * b;
                case "subtract":
                    return a - b;
                default:
                    return a / b;
            }
        }
    }
}
