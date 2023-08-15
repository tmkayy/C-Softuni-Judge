using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box
    {
        public void Swap <T> (List<T> shit, int n1, int n2) => (shit[n1], shit[n2]) = (shit[n2], shit[n1]);
    }
}
