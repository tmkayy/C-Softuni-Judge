using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 1; i <= n; i++)
            {
                string[] smth = Console.ReadLine().Split(' ');
                string first = smth[0];
                string last = smth[1];
                double ocenka = double.Parse(smth[2]);
                Students s = new Students(first, last, ocenka);
                students.Add(s);
            }
            foreach (Students student in students.OrderByDescending(s => s.Grade).ToList())
            {
                Console.WriteLine(student);
            }
        }
        class Students
        {
            string fname;
            string lname;
            double grade;
            public Students(string fname, string lname, double grade)
            {
                Fname = fname;
                Lname = lname;
                Grade = grade;
            }
            public string Fname { get => fname; set => fname = value; }
            public string Lname { get => lname; set => lname = value; }
            public double Grade { get => grade; set => grade = value; }

            public override string ToString()
            {
                return $"{Fname} {Lname}: {Grade:f2}";
            }
        }
    }
}
