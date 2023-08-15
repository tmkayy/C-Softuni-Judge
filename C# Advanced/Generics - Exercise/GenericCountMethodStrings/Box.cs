using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodStrings
{
    internal class Box
    {
        public int Greater<T>(List<T> listofthings, string thing) => listofthings.Where(x => thing.CompareTo(x) < 0).ToList().Count;
    }
}
