using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double sum = 0;
            while (true)
            {
                if (n != "NoMoreMoney")
                {
                    double x = double.Parse(n);
                    if (x < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        break;
                    }
                    sum = sum + x;
                    Console.WriteLine($"Increase: {x:f2}");
                    n = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}