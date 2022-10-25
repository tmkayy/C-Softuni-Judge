using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = " ";
            string resort = " ";
            double price = 0; ;
            if (budget<=100)
            {
                place = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.3;
                        resort = "Camp";
                        break;
                    case "winter":
                        price = budget * 0.7;
                        resort = "Hotel";
                        break;
                }
            }
            else if (budget<=1000)
            {
                place = "Balkans";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.4;
                        resort = "Camp";
                        break;
                    case "winter":
                        price = budget * 0.8;
                        resort = "Hotel";
                        break;
                }
            }
            else
            {
                place = "Europe";
                price = budget * 0.9;
                resort = "Hotel";
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{resort} - {price:f2}");
        }
    }
}
