using System;

namespace Nested_Loops___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool check = false;
            for (int rows = 1; rows <=n ; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (current > n)
                    {
                        check = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (check)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
