using System;
using System.Collections.Generic;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" -> ");
                if (command.Length == 1)
                {
                    break;
                }
                if (companies.ContainsKey(command[0]))
                {
                    if (!companies[command[0]].Contains(command[1]))
                    {
                        companies[command[0]].Add(command[1]);
                    }
                }
                else 
                {
                    List<string> employees = new List<string>();
                    employees.Add(command[1]);
                    companies.Add(command[0], employees);
                }
            }
            foreach (KeyValuePair < string, List<string>> company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (string employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
