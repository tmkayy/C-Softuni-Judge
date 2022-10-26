using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            int n;
            while (input!="Stop")
            {
                n = int.Parse(input);
                if (n < min)
                {
                    min = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
