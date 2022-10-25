using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double himikalki = double.Parse(Console.ReadLine());
            double markeri = double.Parse(Console.ReadLine());
            double litri = double.Parse(Console.ReadLine());
            double procentsale = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(himikalki * 5.8 + markeri * 7.20 + litri * 1.2) - (himikalki * 5.8 + markeri * 7.20 + litri * 1.2) * (procentsale / 100)}");
        }
    }
}
