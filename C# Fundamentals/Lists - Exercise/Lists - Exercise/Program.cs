using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int passangersmax = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();
                if (arr[0] =="end")
                {
                    Console.WriteLine(String.Join(" ", train));
                    return;
                }
                if (arr[0]=="Add")
                {
                    train.Add(int.Parse(arr[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + int.Parse(arr[0]) <= passangersmax)
                        {
                            train[i] += int.Parse(arr[0]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
