using System;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double points1 = double.Parse(Console.ReadLine());
            double points2 = 0;
            double br = 0;
            for (int i = 1; i <= n; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        points2 = points2 + 2000;
                        br++;
                        break;
                    case "F":
                        points2 = points2 + 1200;
                        break;
                    case "SF":
                        points2 = points2 + 720;
                        break;
                }
            }
            double points = points1 + points2;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(points2/n)}");
            Console.WriteLine($"{(br/n)*100:f2}%");
        }
    }
}
