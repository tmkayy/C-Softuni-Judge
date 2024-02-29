using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4
{
    public class Dough
    {
        string type;
        string technique;
        double grams;

        string[] types = { "white", "wholegrain" };
        string[] techniques = { "crispy", "chewy", "homemade" };

        public Dough(string type, string technique, double grams)
        {
            Type = type;
            Technique = technique;
            Grams = grams;
        }

        public string Type { get => type; private set
            {
                if (!types.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                type = value.ToLower();
            }
        }
        public string Technique { get => technique; private set
            {
                if (!techniques.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                technique = value.ToLower();
            }
        }
        public double Grams { get => grams; private set
            {
                if (value > 200||value<1)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }
        public double GetCal()
        {
            double a = 0; double b =0;
            if (type == "white")
                a = 1.5;
            else
                a = 1;
            if (technique == "crispy")
                b = 0.9;
            else if (technique == "chewy")
                b = 1.1;
            else
                b = 1;

            return 2*Grams*a*b;
        }
    }
}
