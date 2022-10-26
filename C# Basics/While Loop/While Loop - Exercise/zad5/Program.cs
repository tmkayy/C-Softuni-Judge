using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            n = n * 100;
            int n2 = (int)n;
            int br = 0;
            while (n2!=0)
            {
                if (n2/200!=0)
                {
                    n2 = n2 - 200;
                    br++;
                }
                else if (n2/100!=0)
                {
                    n2 = n2 - 100;
                    br++;
                }
                else if (n2/50!=0)
                {
                    n2 = n2 - 50;
                    br++;
                }
                else if (n2 / 20 != 0)
                {
                    n2 = n2 - 20;
                    br++;
                }
                else if (n2 / 10 != 0)
                {
                    n2 = n2 - 10;
                    br++;
                }
                else if (n2 / 5 != 0)
                {
                    n2 = n2 - 5;
                    br++;
                }
                else if (n2 / 2 != 0)
                {
                    n2 = n2 - 2;
                    br++;
                }
                else if (n2 / 1 != 0)
                {
                    n2 = n2 - 1;
                    br++;
                    break;
                }
            }
            Console.WriteLine(br);
        }
    }
}
