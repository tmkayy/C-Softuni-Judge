using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace zad3
{
    public class Smartphone : StationaryPhone, IBrowsable
    {
        private Regex siteRegex;

        public Smartphone(string URLOrPhoneNumber) : base(URLOrPhoneNumber)
        {
            this.siteRegex = new Regex(@"^[^\s\d]+$");
        }

        public bool IsLegitSite { get => siteRegex.IsMatch(this.URLOrPhoneNumber); }

        public override void Call() => Console.WriteLine($"Calling... {this.URLOrPhoneNumber}");
        public void Browse() => Console.WriteLine($"Browsing: {this.URLOrPhoneNumber}!");
    }
}
