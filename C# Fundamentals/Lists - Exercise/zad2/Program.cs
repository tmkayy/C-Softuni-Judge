using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine(String.Join(" ", numbers));
                    return;
                }
                string[] arr = command.Split(' ');
                if (arr[0] == "Delete")
                {
                    int x = int.Parse(arr[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == x)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else
                {
                    numbers.Insert(int.Parse(arr[2]), int.Parse(arr[1]));
                }
            }
        }
    }
}
