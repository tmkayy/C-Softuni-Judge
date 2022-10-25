using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double excurzia = double.Parse(Console.ReadLine());
            double puzzle = double.Parse(Console.ReadLine());
            double doll = double.Parse(Console.ReadLine());
            double teddy = double.Parse(Console.ReadLine());
            double minion = double.Parse(Console.ReadLine());
            double truck = double.Parse(Console.ReadLine());
            double br = puzzle + doll + teddy + minion + truck;
            double total = puzzle * 2.6 + doll * 3 + teddy * 4.1 + minion * 8.2 + truck * 2;
            if (br >= 50)
            {
                total = total - total / 4;
            }
            double total2 = total - total / 10;
            if (total2>=excurzia)
            {
                Console.WriteLine($"Yes! {total2 - excurzia:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excurzia - total2:f2} lv needed.");
            }
        }
    }
}
