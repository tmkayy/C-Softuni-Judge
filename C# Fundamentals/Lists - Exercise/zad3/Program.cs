using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] arr = command.Split(' ');
                if (arr[2]== "going!")
                {
                    if (guests.Contains(arr[0]))
                    {
                        Console.WriteLine($"{arr[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(arr[0]);
                    }
                }
                else
                {
                    if (!guests.Contains(arr[0]))
                    {
                        Console.WriteLine($"{arr[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(arr[0]);
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
