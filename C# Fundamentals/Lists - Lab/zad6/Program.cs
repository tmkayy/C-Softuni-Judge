using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                string[] token = command.Split(' ');
                switch (token[0])
                {
                    case "Add":
                        {
                            numbers.Add(int.Parse(token[1]));
                            break;
                        }
                    case "Remove":
                        {
                            numbers.Remove(int.Parse(token[1]));
                            break;
                        }
                    case "RemoveAt":
                        {
                            numbers.RemoveAt(int.Parse(token[1]));
                            break;
                        }
                    case "Insert":
                        {
                            numbers.Insert(int.Parse(token[2]), int.Parse(token[1]));
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
