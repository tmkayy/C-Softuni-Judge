﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        string name;

        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
