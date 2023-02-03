using System;
using System.Collections.Generic;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0]=="register")
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[command[1]]}");
                    }
                    else
                    {
                        parking.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (KeyValuePair<string, string> entry in parking)
            {
                Console.WriteLine($"{entry.Key} => {entry.Value}");
            }
        }
    }
}
