using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            double price = 0;
            int br = 0;
            for (int i = 1; i <= lostgames; i++)
            {
                if (i%2==0&&i%3==0)
                {
                    price += keyboard + headset + mouse;
                    br++;
                    if (br==2)
                    {
                        price += display;
                        br = 0;
                    }
                }
                else if (i%3==0)
                {
                    price += mouse;
                }
                else if (i%2==0)
                {
                    price += headset;
                }
            }
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
