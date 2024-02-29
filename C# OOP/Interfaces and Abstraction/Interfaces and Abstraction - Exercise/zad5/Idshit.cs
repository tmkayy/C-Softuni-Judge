using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Idshit
    {
        string id;

        public Idshit(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public string V { get; }

        public void FakeCheck(string end)
        {
            if (Id.EndsWith(end))
            {
                Console.WriteLine(Id);
            }
        }
    }
}
