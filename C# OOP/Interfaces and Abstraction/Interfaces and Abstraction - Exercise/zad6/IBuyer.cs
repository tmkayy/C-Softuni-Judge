using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    public interface IBuyer
    {
        public int Food { get; set; }
        public void BuyFood();
    }
}
