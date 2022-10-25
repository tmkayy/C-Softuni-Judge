using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int proekti = int.Parse(Console.ReadLine());
            int time = proekti * 3;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {proekti} project/s.");
        }
    }
}
