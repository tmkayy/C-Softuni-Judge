using System;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                default:
                    Console.WriteLine("error");
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        default:
                            Console.WriteLine("error");
                            break;
                        case "banana":
                            price = count * 2.70;
                            break;
                        case "apple":
                            price = count * 1.25;
                            break;
                        case "orange":
                            price = count * 0.90;
                            break;
                        case "grapefruit":
                            price = count * 1.60;
                            break;
                        case "kiwi":
                            price = count * 3;
                            break;
                        case "pineapple":
                            price = count * 5.60;
                            break;
                        case "grapes":
                            price = count * 4.20;
                            break;
                    }
                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = count * 2.50;
                            break;
                        case "apple":
                            price = count * 1.20;
                            break;
                        case "orange":
                            price = count * 0.85;
                            break;
                        case "grapefruit":
                            price = count * 1.45;
                            break;
                        case "kiwi":
                            price = count * 2.70;
                            break;
                        case "pineapple":
                            price = count * 5.50;
                            break;
                        case "grapes":
                            price = count * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
            }
            if (price>0)
            {
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
