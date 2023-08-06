using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        string name;
        int badges;
        List<Pokemon> pokemons;

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Badges = 0;
            Pokemons = pokemons;
        }

        public string Name { get => name; set => name = value; }
        public int Badges { get => badges; set => badges = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
    }
}
