using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secsform = double.Parse(Console.ReadLine());
            double time = distance * secsform;
            double extra = Math.Floor((distance / 15)) * 12.5;
            double total = time + extra;
            if (total >= record)
            {
                Console.WriteLine($"No, he failed! He was {total - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:f2} seconds.");
            }
        }
    }
}
