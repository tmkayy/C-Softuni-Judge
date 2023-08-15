using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuplee <T1, T2>
    {
        T1 item1;
        T2 item2;

        public Tuplee(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1 { get => item1; set => item1 = value; }
        public T2 Item2 { get => item2; set => item2 = value; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
