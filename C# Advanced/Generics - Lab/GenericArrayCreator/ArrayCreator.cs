using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] arr = new T[length];
            return arr.Select(x=>x=item).ToArray();
        }
    }
}
