using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        T smth;

        public Box(T smth)
        {
            Smth = smth;
        }

        public T Smth { get => smth; set => smth = value; }

        public override string ToString() => $"{smth.GetType()}: {smth}";
    }
}
