using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string p1 = " ";
            while (p1 != password)
            {
                p1 = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}