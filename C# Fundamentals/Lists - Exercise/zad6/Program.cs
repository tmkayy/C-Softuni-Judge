using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> cards2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (cards1.Count !=0 && cards2.Count != 0)
            {
                if (cards1[0] > cards2[0])
                {
                    Win(ref cards1, ref cards2);
                }
                else if (cards2[0] > cards1[0])
                {
                    Win(ref cards2, ref cards1);
                }
                cards1.RemoveAt(0);
                cards2.RemoveAt(0);
            }
            if (cards1.Count!=0)
            {
                Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
            }
        }
        static void Win(ref List<int> win, ref List<int> lose)
        {
            win.Add(win[0]); win.Add(lose[0]);
        }
    }
}
