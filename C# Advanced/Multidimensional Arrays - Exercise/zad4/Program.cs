using System;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] n = new string[nums[0], nums[1]];
            for (int i = 0; i < nums[0]; i++)
            {
                string[] lols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < nums[1]; j++)
                {
                    n[i, j] = lols[j];
                }
            }
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0]=="END")
                {
                    return;
                }
                try
                {
                    int n11 = int.Parse(s[1]); int n12 = int.Parse(s[2]); int n21 = int.Parse(s[3]); int n22 = int.Parse(s[4]);
                    (n[n11, n12], n[n21, n22]) = (n[n21, n22], n[n11, n12]);
                    for (int i = 0; i < nums[0]; i++)
                    {
                        for (int j = 0; j < nums[1]; j++)
                        {
                            Console.Write(n[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
