using System;
using System.Linq;

namespace Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagon = new int[n];
            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", wagon));
            Console.WriteLine(wagon.Sum());
        }
    }
}
