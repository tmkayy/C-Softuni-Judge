using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuplee<T1, T2, T3>
    {
        T1 item1;
        T2 item2;
        T3 item3;

        public Threeuplee(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public T1 Item1 { get => item1; set => item1 = value; }
        public T2 Item2 { get => item2; set => item2 = value; }
        public T3 Item3 { get => item3; set => item3 = value; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
