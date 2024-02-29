using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Robot:Idshit
    {
        string model;

        public Robot(string model, string id) : base(id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get => model; set => model = value; }
    }
}
