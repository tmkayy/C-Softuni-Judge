using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());
            if (ocenka>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
