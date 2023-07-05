using System;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] s = new string[nums[0], nums[1]];
            int br = 0;
            for (int i = 0; i < nums[0]; i++)
            {
                string[] lols = Console.ReadLine().Split(' ');
                for (int j = 0; j < nums[1]; j++)
                {
                    s[i, j] = lols[j];
                }
            }
            for (int i = 0; i < nums[0]-1; i++)
            {
                for (int j = 0; j < nums[1]-1; j++)
                {
                    bool OK = false;
                    string shit = s[i, j];
                    for (int h = i; h < i+2; h++)
                    {
                        for (int l = j; l < j+2; l++)
                        {
                            if (s[h, l]==shit)
                            {
                                OK = true;
                            }
                            else
                            {
                                OK = false;
                                break;
                            }
                        }
                        if (!OK)
                        {
                            break;
                        }
                    }
                    if (OK== true)
                    {
                        br++;
                    }
                }
            }
            Console.WriteLine(br);
        }
    }
}
