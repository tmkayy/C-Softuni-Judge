﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        string name;
        string element;
        int health;

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public string Name { get => name; set => name = value; }
        public string Element { get => element; set => element = value; }
        public int Health { get => health; set => health = value; }
    }
}
