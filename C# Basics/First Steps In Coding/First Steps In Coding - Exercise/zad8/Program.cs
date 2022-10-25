using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double fake_Js = tax - tax * 40 / 100;
            double drip = fake_Js - fake_Js * 20 / 100;
            double ball = drip / 4;
            double exxxtra = ball / 5;
            Console.WriteLine($"{tax+fake_Js+drip+ball+exxxtra}");

        }
    }
}
