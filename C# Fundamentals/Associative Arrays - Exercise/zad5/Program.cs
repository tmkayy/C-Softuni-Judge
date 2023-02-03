using System;
using System.Collections.Generic;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ");
                if (command.Length == 1) 
                {
                    break;
                }
                if (courses.ContainsKey(command[0]))
                {
                    courses[command[0]].Add(command[1]);
                }
                else
                {
                    List<string> members = new List<string>();
                    members.Add(command[1]);
                    courses.Add(command[0], members);
                }
            }
            foreach (KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string member in course.Value)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
