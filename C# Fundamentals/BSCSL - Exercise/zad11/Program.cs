using System;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalcost = 0;
            double cost;
            for (int i = 1; i <= n; i++)
            {
                cost = 0;
                double price = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                double count = double.Parse(Console.ReadLine());
                cost += ((days * count) * price);
                totalcost += cost;
                Console.WriteLine($"The price for the coffee is: ${cost:f2}");
            }
            Console.WriteLine($"Total: ${totalcost:f2}");
        }
    }
}
