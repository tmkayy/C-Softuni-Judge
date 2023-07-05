using System;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] mat = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                string z = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = z[j].ToString();
                }
            }
            string s = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j]==s)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{s} does not occur in the matrix");
        }
    }
}
