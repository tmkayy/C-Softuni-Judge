using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double broistranici = double.Parse(Console.ReadLine());
            double straniciperhr = double.Parse(Console.ReadLine());
            double dni = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Truncate((broistranici/straniciperhr)/dni)}");
        }
    }
}
