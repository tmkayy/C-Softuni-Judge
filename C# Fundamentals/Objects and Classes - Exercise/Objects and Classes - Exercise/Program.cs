using System;

namespace Objects_and_Classes___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            for (int i = 1; i <= n; i++)
            {
                int r1 = new Random().Next(0, phrases.Length);
                int r2 = new Random().Next(0, events.Length);
                int r3 = new Random().Next(0, authors.Length);
                int r4 = new Random().Next(0, cities.Length);
                Ad ad = new Ad(phrases[r1], events[r2], authors[r3], cities[r4]);
                Console.WriteLine(ad);
            }
        }
        class Ad
        {
            string phrases;
            string events;
            string authors;
            string cities;

            public Ad(string phrases, string events, string authors, string cities)
            {
                Phrases = phrases;
                Events = events;
                Authors = authors;
                Cities = cities;
            }

            public string Phrases { get => phrases; set => phrases = value; }
            public string Events { get => events; set => events = value; }
            public string Authors { get => authors; set => authors = value; }
            public string Cities { get => cities; set => cities = value; }

            public override string ToString()
            {
                return $"{Phrases} {Events} {Authors} – {Cities}.";
            }
        }
    }
}
