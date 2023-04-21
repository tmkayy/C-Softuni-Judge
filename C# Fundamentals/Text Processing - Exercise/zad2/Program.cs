using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int sum1 = 0;
            if (s[0].Length == s[1].Length)
            {
                for (int i = 0; i < s[0].Length; i++)
                {
                    sum1 += s[0][i] * s[1][i];
                }
            }
            else
            {
                if (s[0].Length > s[1].Length)
                {
                    sum1 = Bigger(s[0], s[1], sum1);
                }
                else
                {
                    sum1 = Bigger(s[1], s[0], sum1);
                }
            }
            Console.WriteLine(sum1);
        }
        static int Bigger(string a, string b, int sum1) 
        {
            int x = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum1 += a[i] * b[i];
                x = i;
            }
            for (int j = x+1; j < a.Length; j++)
            {
                sum1 += a[j];
            }
            return sum1;
        }
    }
}
