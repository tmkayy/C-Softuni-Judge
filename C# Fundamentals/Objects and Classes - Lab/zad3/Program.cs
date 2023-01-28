using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] entry = Console.ReadLine().Split('_').ToArray();
                Song song = new Song();
                song.Type = entry[0];
                song.Name = entry[1];
                song.Time = entry[2];
                songs.Add(song);
            }
            string type = Console.ReadLine();
            switch (type)
            {
                case "all":
                    foreach (Song song in songs)
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;
                default:
                    foreach (Song song in songs)
                    {
                        if (type==song.Type)
                        {
                            Console.WriteLine(song.Name);
                        }
                    }
                    break;
            }
        }
    }
    class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
