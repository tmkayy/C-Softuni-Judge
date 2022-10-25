using System;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            if (n>=100&&n<=200)
            {
                Console.WriteLine(" ");
            }
            else if (n==0)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
