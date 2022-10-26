using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cake = w * h;
            string slice = " ";
            int sum = 0;
            int n = 0;
            while (true)
            {
                slice = Console.ReadLine();
                if (slice=="STOP")
                {
                    break;
                }
                n = int.Parse(slice);
                sum = sum + n;
                if (sum>cake)
                {
                    Console.WriteLine($"No more cake left! You need {sum - cake} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{cake - sum} pieces are left.");
        }
    }
}
