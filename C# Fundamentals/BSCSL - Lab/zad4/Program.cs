using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m= int.Parse(Console.ReadLine());
            int time1 = h * 60 + m + 30;
            int h2 = time1 / 60;
            int m2 = time1 % 60;
            if (h2==24)
            {
                h2 = 0;
            }
            if (m2<10)
            {
                Console.WriteLine($"{h2}:0{m2}");
            }
            else
            {
                Console.WriteLine($"{h2}:{m2}");
            }
        }
    }
}
