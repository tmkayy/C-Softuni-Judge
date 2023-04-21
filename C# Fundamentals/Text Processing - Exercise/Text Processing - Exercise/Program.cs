using System;

namespace Text_Processing___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(", ");
            foreach (string s2 in s)
            {
                if (s2.Length >=3&&s2.Length<=16)
                {
                    bool OK = true;
                    foreach (char item in s2)
                    {
                        if (char.IsLetterOrDigit(item) || item == '-' || item == '_')
                        {
                            OK = true;
                        }
                        else
                        {
                            OK = false;
                            break;
                        }
                    }
                    if (OK)
                    {
                        Console.WriteLine(s2);
                    }
                }
            }
        }
    }
}
