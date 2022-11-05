using System;
using System.Runtime.InteropServices;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            string product;
            double coinsum = 0;
            double x;
            while (true)
            {
                x = double.Parse(coin);
                if (x == 0.1 || x == 0.2 || x == 0.5 || x == 1 || x == 2)
                {
                    coinsum += x;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {x}");
                }
                coin = Console.ReadLine();
                if (coin == "Start")
                {
                    break;
                }
            }
            while (true)
            {
                product = Console.ReadLine();
                switch (product)
                {
                    case "Nuts":
                        if (coinsum - 2>=0)
                        {
                            coinsum -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coinsum - 0.7 >= 0)
                        {
                            coinsum -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coinsum - 1.5 >= 0)
                        {
                            coinsum -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coinsum - 0.8 >= 0)
                        {
                            coinsum -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coinsum - 1 >= 0)
                        {
                            coinsum -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "End":
                        Console.WriteLine($"Change: {coinsum:f2}");
                        return;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
        }
    }
}
