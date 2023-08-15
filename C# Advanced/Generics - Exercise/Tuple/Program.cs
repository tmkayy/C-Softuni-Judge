using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' '); string lol = $"{s1[0]} {s1[1]}";
            Tuplee<string, string> first = new Tuplee<string, string>(lol, s1[2]);
            string[] s2 = Console.ReadLine().Split(' ');
            Tuplee<string, int> second = new Tuplee<string, int>(s2[0], int.Parse(s2[1]));
            string[] s3 = Console.ReadLine().Split(' ');
            Tuplee<string, double> third= new Tuplee<string, double>(s3[0], double.Parse(s3[1]));
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
