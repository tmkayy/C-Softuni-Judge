using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double studio = 0;
            double appartment = 0;
            switch (month)
            {
                case "May":
                    studio = 50*count;
                    appartment = 65*count;
                    if (count>7&&count<=14)
                    {
                        studio =studio * 0.95;
                    }
                    else if (count>14)
                    {
                        studio = studio * 0.7;
                        appartment =appartment * 0.9;
                    }
                    break;
                case "June":
                    studio = 75.20*count;
                    appartment = 68.70 * count;
                    if (count > 14)
                    {
                        studio = studio * 0.8;
                        appartment = appartment * 0.9;
                    }
                    break;
                case "July":
                    studio = 76 * count;
                    appartment = 77 * count;
                    if (count > 14)
                    {
                        appartment = appartment * 0.9;
                    }
                    break;
                case "August":
                    studio = 76 * count;
                    appartment = 77 * count;
                    if (count > 14)
                    {
                        appartment =appartment * 0.9;
                    }
                    break;
                case "September":
                    studio = 75.20 * count;
                    appartment = 68.70 * count;
                    if (count > 14)
                    {
                        studio = studio * 0.8;
                        appartment = appartment * 0.9;
                    }
                    break;
                case "October":
                    studio = 50 * count;
                    appartment = 65 * count;
                    if (count > 7 && count <= 14)
                    {
                        studio = studio * 0.95;
                    }
                    else if (count > 14)
                    {
                        studio = studio * 0.7;
                        appartment =appartment * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {appartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
