using System;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] c = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string rrrrrrrrrrrrrrrrr = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rrrrrrrrrrrrrrrrr[j];
                }
            }
            int horsetypashit = 0;
            for (int MENACE = 8; MENACE >= 1; MENACE--)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (c[i, j] == 'K')
                        {
                            int HOWSYOURLITTLECHESSTHINGGOING = 0;
                            try
                            {
                                if (c[i - 1, j - 2] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i - 2, j - 1] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i - 2, j + 1] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i - 1, j + 2] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i + 1, j + 2] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i + 2, j + 1] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i + 2, j - 1] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            try
                            {
                                if (c[i + 1, j - 2] == 'K')
                                {
                                    HOWSYOURLITTLECHESSTHINGGOING++;
                                }
                            }
                            catch { }
                            if (HOWSYOURLITTLECHESSTHINGGOING == MENACE)
                            {
                                c[i, j] = '0';
                                horsetypashit++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(horsetypashit);
        }

    }
}
