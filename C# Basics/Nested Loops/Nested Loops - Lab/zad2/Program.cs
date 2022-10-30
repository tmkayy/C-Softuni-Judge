using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int first = 1; first <= 10; first++)
            {
                for (int second = 1; second <= 10; second++)
                {
                    Console.WriteLine($"{first} * {second} = {first*second}");
                }
            }
        }
    }
}
