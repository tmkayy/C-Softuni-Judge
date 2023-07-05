using System;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] mat = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] z = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < z.Length; j++)
                {
                    mat[i] = z;
                }
            }
            while (true)
            {
                string[] s = Console.ReadLine().Split(" ");
                switch (s[0])
                {
                    case "END":
                        Console.WriteLine(string.Join(Environment.NewLine, mat.Select(x => string.Join(' ', x)))); //took a while to figure out but it looks better
                        return;
                    case "Add":
                        try
                        {
                            mat[int.Parse(s[1])] [int.Parse(s[2])] += int.Parse(s[3]);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        try
                        {
                            mat[int.Parse(s[1])][int.Parse(s[2])] -= int.Parse(s[3]);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }
            }
        }
    }
}
