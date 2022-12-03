using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "End":
                        Console.WriteLine(String.Join(" ", numbers));
                        return;
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) < numbers.Count && int.Parse(command[2]) >= 0)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < numbers.Count && int.Parse(command[1]) >= 0)
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                for (int i = 1; i <= int.Parse(command[2]); i++)
                                {
                                    Left(numbers);
                                }
                                break;
                            case "right":
                                for (int i = 1; i <= int.Parse(command[2]); i++)
                                {
                                    Right(numbers);
                                }
                                break;
                        }
                        break;
                }
            }
        }
        static List<int> Left(List<int> numbers)
        {
            numbers.Add(numbers[0]); numbers.Remove(numbers[0]);
            return numbers;
        }
        static List<int> Right(List<int> numbers)
        {
            numbers.Insert(0, numbers[numbers.Count - 1]); numbers.RemoveAt(numbers.Count - 1);
            return numbers;
        }
    }
}
