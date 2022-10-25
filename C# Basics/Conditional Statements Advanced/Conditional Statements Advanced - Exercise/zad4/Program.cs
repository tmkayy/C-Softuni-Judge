using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double ribari = double.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (ribari<=6)
                    {
                        price = price * 0.9;
                        if (ribari%2==0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else if (ribari>6&&ribari<=11)
                    {
                        price = price * 0.85;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else
                    {
                        price = price * 0.75;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (ribari <= 6)
                    {
                        price = price * 0.9;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else if (ribari > 6 && ribari <= 11)
                    {
                        price = price * 0.85;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else
                    {
                        price = price * 0.75;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    if (ribari <= 6)
                    {
                        price = price * 0.9;
                    }
                    else if (ribari > 6 && ribari <= 11)
                    {
                        price = price * 0.85;
                    }
                    else
                    {
                        price = price * 0.75;
                    }
                    break;
                case "Winter":
                    price = 2600;
                    if (ribari <= 6)
                    {
                        price = price * 0.9;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else if (ribari > 6 && ribari <= 11)
                    {
                        price = price * 0.85;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    else
                    {
                        price = price * 0.75;
                        if (ribari % 2 == 0)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
            }
            if (budget>=price)
            {
                Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
            }
        }
    }
}
