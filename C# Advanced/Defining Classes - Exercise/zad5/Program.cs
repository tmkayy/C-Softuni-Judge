using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier d = new DateModifier(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(d.diff());
        }
    }
}
