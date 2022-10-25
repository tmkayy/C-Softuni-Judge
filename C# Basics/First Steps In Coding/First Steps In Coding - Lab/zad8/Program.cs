using System;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double cena1 = dog * 2.5;
            double cena2 = cat * 4;
            Console.WriteLine($"{cena1 + cena2} lv.");
        }
    }
}
