using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        Stack<T> s;

        public Box()
        {
            s = new Stack<T>();
        }

        public Stack<T> S { get => s; }

        public void Add(T elemnt)
        {
            S.Push(elemnt);
        }
        public T Remove()
        {
            return S.Pop();
        }
        public int Count
        {
            get { return S.Count; }
        }
    }
}
