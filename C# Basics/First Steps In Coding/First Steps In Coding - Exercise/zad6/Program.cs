using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double razreditel = double.Parse(Console.ReadLine());
            double hrs = double.Parse(Console.ReadLine());
            Console.WriteLine($"{((nailon + 2) * 1.5 + (paint + paint * 10 / 100) * 14.5 + razreditel * 5 + 0.4) + (((nailon + 2) * 1.5 + (paint + paint * 10 / 100) * 14.5 + razreditel * 5 + 0.4) * 30 / 100) * hrs}");
        }
    }
}
