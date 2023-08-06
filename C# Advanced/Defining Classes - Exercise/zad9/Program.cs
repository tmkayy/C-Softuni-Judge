using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Tournament")
                    break;
                Pokemon p = new Pokemon(s[1], s[2], int.Parse(s[3]));
                if (trainers.Any(x => x.Name == s[0]))
                {
                    trainers.First(x=>x.Name == s[0]).Pokemons.Add(p);
                }
                else
                {
                    Trainer t = new Trainer(s[0], new List<Pokemon>());
                    t.Pokemons.Add(p); trainers.Add(t);
                }
            }
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "End")
                    break;
                foreach (var trainer in trainers.Where(x=>x.Pokemons.Any(x=>x.Element==s)))
                {
                    trainer.Badges += 1;
                }
                foreach (var trainer in trainers.Where(x => !x.Pokemons.Any(x => x.Element == s)))
                {
                    trainer.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }

        }
    }
}
