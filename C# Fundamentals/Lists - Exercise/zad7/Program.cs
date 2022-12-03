using System;
using System.Collections.Generic;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            List<string> final = new List<string>();
            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                string[] arr = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < arr.Length; j++)
                {
                    final.Add(arr[j]);
                }
            }
            Console.WriteLine(String.Join(" ", final));
        }
    }
}
