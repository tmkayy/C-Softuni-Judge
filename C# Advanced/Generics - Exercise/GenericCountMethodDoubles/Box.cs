using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodDoubles
{
    internal class Box
    {
        public int Greater<T>(List<T> listofthings, double thing) => listofthings.Where(x => thing.CompareTo(x) < 0).ToList().Count;
    }
}
