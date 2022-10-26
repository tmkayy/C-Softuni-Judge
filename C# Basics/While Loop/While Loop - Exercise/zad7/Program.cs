using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int V = w * l * h;
            int sum = 0;
            string box;
            int n;
            while (true)
            {
                box = Console.ReadLine();
                if (box == "Done")
                {
                    break;
                }
                n = int.Parse(box);
                sum = sum + n;
                if (sum>V)
                {
                    break;
                }
            }
            if (V>=sum)
            {
                Console.WriteLine($"{V-sum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {sum-V} Cubic meters more.");
            }
        }
    }
}
