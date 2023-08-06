using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        string d1;
        string d2;

        public DateModifier(string d1, string d2)
        {
            D1 = d1;
            D2 = d2;
        }

        public string D1 { get => d1; set => d1 = value; }
        public string D2 { get => d2; set => d2 = value; }

        public int diff()
        {
            DateTime dt1 = DateTime.Parse(D1);
            DateTime dt2 = DateTime.Parse(D2);
            return Math.Abs((dt1 - dt2).Days);
        }
    }
}
