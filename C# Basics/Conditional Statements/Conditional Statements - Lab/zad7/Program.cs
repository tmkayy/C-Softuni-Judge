using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }
            else if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*Math.Pow(a, 2):f3}");
            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * b)/2:f3}");
            }
        }
    }
}
