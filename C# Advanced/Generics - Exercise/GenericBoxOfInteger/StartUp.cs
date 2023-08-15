using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                Box<int> b = new Box<int>(n1);
                Console.WriteLine(b);
            }
        }
    }
}
