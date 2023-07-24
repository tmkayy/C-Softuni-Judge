using System;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Action<double> vat = (a) => Console.WriteLine($"{a + a / 5:f2}");
            foreach (var item in nums)
            {
                vat(item);
            }
        }
    }
}
