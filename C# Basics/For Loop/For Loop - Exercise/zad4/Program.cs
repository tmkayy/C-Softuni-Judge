using System;
using System.Threading;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toy = double.Parse(Console.ReadLine());
            double add = 10;
            double moneysum = 0;
            double toysum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2==0)
                {
                    moneysum = moneysum + add - 1;
                    add = add + 10;
                }
                else
                {
                    toysum = toysum + toy;
                }
            }
            double finalsum = toysum + moneysum;
            if (finalsum>=price)
            {
                Console.WriteLine($"Yes! {finalsum - price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {price - finalsum:f2}");
            }
        }
    }
}
