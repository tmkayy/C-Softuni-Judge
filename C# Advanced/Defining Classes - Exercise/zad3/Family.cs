using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> fam;

        public Family(List<Person> fam)
        {
            Fam = fam;
        }

        public List<Person> Fam { get => fam; set => fam = value; }

        public void AddMember (Person member) => Fam.Add(member);
        public Person GetOldestMember() => Fam.Find(x => x.Age == Fam.Max(x=>x.Age));
    }
}
