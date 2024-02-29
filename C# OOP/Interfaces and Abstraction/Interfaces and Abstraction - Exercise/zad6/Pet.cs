using System;
using System.Collections.Generic;
using System.Text;

namespace zad5
{
    public class Pet:Bdayy
    {
        string name;
        string bday;

        public Pet(string name, string bday)
        {
            Bday = bday;
            Name = name;
        }

        public string Bday { get => bday; set => bday = value; }
        public string Name { get => name; set => name = value; }
    }
}
