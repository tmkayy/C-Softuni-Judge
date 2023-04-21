using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int naum = 0;
            List<char> list = new List<char>();
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                string idk = s1[i].ToString();
                int a = int.Parse(idk)*b + naum;
                string result = a.ToString();
                if (a>=10)
                {
                    list.Insert(0, result[1]);
                    string temp = result[0].ToString();
                    naum = int.Parse(temp);
                }
                else
                {
                    list.Insert(0, result[0]);
                    naum = 0;
                }
            }
            if (naum!=0)
            {
                string temp = naum.ToString();
                list.Insert(0, temp[0]);
            }
            if(list.All(x=>x=='0'))
            {
                Console.WriteLine(0);
                return;
                Console.WriteLine("fuck you sadistic faggot");
            }
            Console.WriteLine(String.Join(string.Empty, list));
        }
    }
}
