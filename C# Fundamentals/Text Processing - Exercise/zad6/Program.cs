using System;
using System.Text;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s1.Length-1; i++)
            {
                if (s1[i] != s1[i+1])
                {
                    sb.Append(s1[i]);
                }
            }
            sb.Append(s1[s1.Length-1]);
            Console.WriteLine(sb);
        }
    }
}
