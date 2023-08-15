using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().Split(' ');
            string lol = $"{s1[0]} {s1[1]}"; string lol2 = String.Join(" ", s1.Skip(3));
            var s2 = Console.ReadLine().Split(' ');
            var s3 = Console.ReadLine().Split(' ');
            var t1 = new Threeuplee<string, string, string>(lol, s1[2], lol2);
            Console.WriteLine(t1);
            var t2 = new Threeuplee<string, int, string>(s2[0], int.Parse(s2[1]), s2[2] == "drunk" ? "True" : "False");
            Console.WriteLine(t2);
            var t3 = new Threeuplee<string, double, string>(s3[0], double.Parse(s3[1]), s3[2]);
            Console.WriteLine(t3);
        }
    }
}
