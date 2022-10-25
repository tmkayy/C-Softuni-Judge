using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double obleklo = double.Parse(Console.ReadLine());
            double priceobleklo = statisti * obleklo;
            double dekor = budget / 10;
            if (statisti > 150)
            {
                priceobleklo = priceobleklo - priceobleklo / 10;
            }
            double total = dekor + priceobleklo;
            if (total > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
            }
        }
    }
}
