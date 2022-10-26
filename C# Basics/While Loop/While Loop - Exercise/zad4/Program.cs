using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int sum = 0;
            int n;
            while (true)
            {
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    n = int.Parse(steps);
                    sum = sum + n;
                    if (sum >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!\n{sum - 10000} steps over the goal!");
                        return;
                    }
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");
                    return;
                }
                n = int.Parse(steps);
                sum = sum + n;
                if (sum >=10000)
                {
                    Console.WriteLine($"Goal reached! Good job!\n{sum - 10000} steps over the goal!");
                    return;
                }
                steps = Console.ReadLine();
            }
        }
    }
}
