using System;

namespace zad4
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] s = Console.ReadLine().Split(' ');
                string[] dough = Console.ReadLine().Split(' ');
                Dough d = new Dough(dough[1], dough[2], double.Parse(dough[3]));
                Pizza p = new Pizza(s[1], d);
                while (true)
                {
                    string[] command = Console.ReadLine().Split(' ');
                    if (command[0]=="END")
                    {
                        Console.WriteLine(p);
                        return;
                    }
                    p.AddTopping(new Topping(command[1], double.Parse(command[2])));
                }
            }
            catch(ArgumentException ex) { Console.WriteLine(ex.Message); return; }
        }
    }
}
