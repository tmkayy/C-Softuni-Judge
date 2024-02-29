using System;
using System.Collections.Generic;
using System.Text;

namespace zad5
{
    public interface Bdayy
    {
        public string Bday { get; set; }
        
        public void Birth(string year)
        {
            if (Bday.EndsWith(year))
            {
                Console.WriteLine(Bday);
            }
        }
    }
}
