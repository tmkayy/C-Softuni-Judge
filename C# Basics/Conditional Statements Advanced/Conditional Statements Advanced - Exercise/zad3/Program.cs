using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            switch (flower)
            {
                case "Roses":
                    if (count>80)
                    {
                        price = count * 5 * 0.9;
                    }
                    else
                    {
                        price = count * 5;
                    }
                    break;
                case "Dahlias":
                    if (count > 90)
                    {
                        price = count * 3.8 * 0.85;
                    }
                    else
                    {
                        price = count * 3.8;
                    }
                    break;
                case "Tulips":
                    if (count > 80)
                    {
                        price = count * 2.8 * 0.85;
                    }
                    else
                    {
                        price = count * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (count < 120)
                    {
                        price = count * 3 * 1.15;
                    }
                    else
                    {
                        price = count * 3;
                    }
                    break;
                case "Gladiolus":
                    if (count < 80)
                    {
                        price = count * 2.5 * 1.2;
                    }
                    else
                    {
                        price = count * 2.5;
                    }
                    break;
            }
            if (budget>=price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget-price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price-budget:f2} leva more.");
            }
        }
    }
}
