using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString(RandomList r)
        {
            int n = new Random().Next(0, r.Count - 1);
            string s = r[n]; r.RemoveAt(n);
            return s;
        }
    }
}
