using System;
using System.Diagnostics.Tracing;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                string x = i.ToString();
                for (int j = 0; j < x.Length; j++)
                {
                    if (j%2==1)
                    {
                        sum1 += x[j];
                    }
                    else
                    {
                        sum2 += x[j];
                    }
                }
                if (sum1 == sum2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
