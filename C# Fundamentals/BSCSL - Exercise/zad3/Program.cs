using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            price = count * 8.45;
                            if (count >= 30)
                            {
                                price *= 0.85;
                            }
                            break;
                        case "Business":
                            price = count * 10.9;
                            if (count >= 100)
                            {
                                price -= 10 * 10.9;
                            }
                            break;
                        case "Regular":
                            price = count * 15;
                            if (count >= 10 && count <= 20)
                            {
                                price *= 0.95;
                            }
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            price = count * 9.8;
                            if (count >= 30)
                            {
                                price *= 0.85;
                            }
                            break;
                        case "Business":
                            price = count * 15.6;
                            if (count >= 100)
                            {
                                price -= 10 * 15.6;
                            }
                            break;
                        case "Regular":
                            price = count * 20;
                            if (count >= 10 && count <= 20)
                            {
                                price *= 0.95;
                            }
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            price = count * 10.46;
                            if (count >= 30)
                            {
                                price *= 0.85;
                            }
                            break;
                        case "Business":
                            price = count * 16;
                            if (count >= 100)
                            {
                                price -= 10 * 10.9;
                            }
                            break;
                        case "Regular":
                            price = count * 22.5;
                            if (count >= 10 && count <= 20)
                            {
                                price *= 0.95;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
