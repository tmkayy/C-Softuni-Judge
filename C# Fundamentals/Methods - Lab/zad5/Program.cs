using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Price(drink, count):f2}");
        }
        static double Price(string drink, int count)
        {
            switch (drink)
            {
                case "coffee":
                    return count * 1.5;
                case "water":
                    return count * 1;
                case "coke":
                    return count * 1.4;
                default:
                    return count * 2;
            }
        }
    }
}
