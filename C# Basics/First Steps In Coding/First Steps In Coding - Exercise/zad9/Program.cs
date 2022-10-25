using System;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double length2 = length / 10;
            double width2 = width / 10;
            double height2 = height / 10;
            double V = length2 * width2 * height2;
            Console.WriteLine($"{V - V * procent / 100}");

        }
    }
}
