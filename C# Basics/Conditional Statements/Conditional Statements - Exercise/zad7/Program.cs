using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double Nprice = N * 250;
            double Mprice = M * (Nprice * 0.35);
            double Pprice = P * (Nprice * 0.1);
            double total = Nprice + Mprice + Pprice;
            if (N > M)
            {
                total = total - total * 0.15;
            }
            if (total <= budget)
            {
                Console.WriteLine($"You have {budget - total:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total-budget:f2} leva more!");
            }
        }
    }
}
