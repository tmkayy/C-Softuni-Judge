using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            int n;
            while (input != "Stop")
            {
                n = int.Parse(input);
                if (n > max)
                {
                    max = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
