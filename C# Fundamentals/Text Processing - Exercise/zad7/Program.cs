using System;
using System.Text;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='>')
                {
                    sb.Append(s[i]);
                    string temp = s[i+1].ToString();
                    int pow  = int.Parse(temp);
                    for (int j = 1; j <= pow; j++)
                    {
                        if (i + j + 1 >= s.Length)
                        {
                            break;
                        }
                        if (s[i + j] == '>' && char.IsDigit(s[i+j+1]))
                        {
                            string temp2 = s[i+j+1].ToString();
                            int pow2 = int.Parse(temp2);
                            pow++;
                            pow += pow2;
                            sb.Append(s[i+j]);
                        }
                    }
                    i += pow;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
