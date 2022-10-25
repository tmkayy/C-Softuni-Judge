using System;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string znak = Console.ReadLine();
            double final = 0;
            string check = " ";
            switch (znak)
            {
                case "+":
                    final = N1 + N2;
                    if (final % 2 == 0)
                    {
                        check = "even";
                    }
                    else
                    {
                        check = "odd";
                    }
                    break;
                case "-":
                    final = N1 - N2;
                    if (final % 2 == 0)
                    {
                        check = "even";
                    }
                    else
                    {
                        check = "odd";
                    }
                    break;
                case "*":
                    final = N1 * N2;
                    if (final % 2 == 0)
                    {
                        check = "even";
                    }
                    else
                    {
                        check = "odd";
                    }
                    break;
                case "/":
                    final = N1 / N2;
                    if (N2==0)
                    {
                        check = "no";
                    }
                    break;
                case "%":
                    final = N1 % N2;
                    if (N2 == 0)
                    {
                        check = "no";
                    }
                    break;
            }
            if (check=="no")
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (check=="odd"|| check == "even")
            {
                if (znak == "/")
                {
                    Console.WriteLine($"{N1} {znak} {N2} = {final:f2} - {check}");
                }
                else
                {
                    Console.WriteLine($"{N1} {znak} {N2} = {final} - {check}");
                }
            }
            else
            {
                if (znak == "/")
                {
                    Console.WriteLine($"{N1} {znak} {N2} = {final:f2}");
                }
                else
                {
                    Console.WriteLine($"{N1} {znak} {N2} = {final}");
                }
            }
        }
    }
}
