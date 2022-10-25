using System;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            double cena1 = m2 * 7.61;
            double discount = cena1 * 18 / 100;
            double cena2 = cena1 - discount;
            Console.WriteLine($"The final price is {cena2} lv.");
            Console.WriteLine($"The discount is {discount} lv.");
        }
    }
}
