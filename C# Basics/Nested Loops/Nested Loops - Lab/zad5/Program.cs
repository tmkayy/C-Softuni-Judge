using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            double sum = 0;
            double n;
            while (country!="End")
            {
                double minimum = double.Parse(Console.ReadLine());
                while (sum<minimum)
                {
                    n = double.Parse(Console.ReadLine());
                    sum = sum+n;
                }
                sum = 0;
                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }
        }
    }
}
