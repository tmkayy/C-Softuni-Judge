using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for (int i = floor; i > 0; i--)
            {
                string type = " ";
                if (i == floor)
                {
                    type = "L";
                }
                else if (i%2==0)
                {
                    type = "O";
                }
                else if (i%2==1)
                {
                    type = "A";
                }
                for (int j = 0; j < room; j++)
                {
                    Console.Write($"{type}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
