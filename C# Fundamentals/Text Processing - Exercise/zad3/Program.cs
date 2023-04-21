using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] a = {'\\', '.' };
            string[] s = Console.ReadLine().Split(a);
            Console.WriteLine($"File name: {s[s.Length-2]}\nFile extension: {s[s.Length - 1]}");
        }
    }
}
