﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var pup = new Puppy();
            pup.Eat();
            pup.Bark();
            pup.Weep();
        }
    }
}
