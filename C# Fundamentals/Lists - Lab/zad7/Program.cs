using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool Changed = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    if (Changed)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }
                    break;
                }
                string[] token = command.Split(' ');
                switch (token[0])
                {
                    case "Add":
                        {
                            numbers.Add(int.Parse(token[1]));
                            Changed = true;
                            break;
                        }
                    case "Remove":
                        {
                            numbers.Remove(int.Parse(token[1]));
                            Changed = true;
                            break;
                        }
                    case "RemoveAt":
                        {
                            numbers.RemoveAt(int.Parse(token[1]));
                            Changed = true;
                            break;
                        }
                    case "Insert":
                        {
                            numbers.Insert(int.Parse(token[2]), int.Parse(token[1]));
                            Changed |= true;
                            break;
                        }
                    case "Contains":
                        {
                            if (numbers.Contains(int.Parse(token[1])))
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No such number");
                            }
                            break;
                        }
                    case "GetSum":
                        {
                            Console.WriteLine(numbers.Sum());
                            break;
                        }
                    case "Filter":
                        {
                            Filter(numbers, token[1], int.Parse(token[2]));
                            break;
                        }
                    case "PrintEven":
                        {
                            PrintEven(numbers);
                            break;
                        }
                    case "PrintOdd":
                        {
                            PrintOdd(numbers);
                            break;
                        }
                }
            }
        }

        static void PrintEven(List<int> numbers)
        {
            List<int> x = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    x.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", x));
        }

        static void PrintOdd(List<int> numbers)
        {
            List<int> x2 = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    x2.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", x2));
        }

        static void Filter(List<int> numbers, string operation, int n)
        {
            List<int> x3 = new List<int>();
            switch (operation)
            {
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > n)
                        {
                            x3.Add(numbers[i]);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= n)
                        {
                            x3.Add(numbers[i]);
                        }
                    }
                    break;
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < n)
                        {
                            x3.Add(numbers[i]);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= n)
                        {
                            x3.Add((int)numbers[i]);
                        }
                    }
                    break;
            }
            Console.WriteLine(string.Join(" ", x3));
        }
    }
}
