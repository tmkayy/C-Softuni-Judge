using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            while (true)
            {
                string[] Info = Console.ReadLine().Split(' ').ToArray();
                if (Info[0] == "end")
                {
                    break;
                }
                if (Check(Students, Info[0], Info[1]))
                {
                    Student s = new Student();
                    s.fname = Info[0];
                    s.lname = Info[1];
                    s.age = Info[2];
                    s.town = Info[3];
                    Students.Add(s);
                }
                else
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        if (Students[i].fname == Info[0] && Students[i].lname == Info[1])
                        {
                            Students[i].age = Info[2];
                            Students[i].town = Info[3];
                        }
                    }
                }
            }
            string town = Console.ReadLine();
            foreach (Student student in Students)
            {
                if (student.town == town)
                {
                    Console.WriteLine(student);
                }
            }
        }
        static bool Check(List<Student> Students, string fname, string lname)
        {
            foreach (Student student in Students)
            {
                if (student.fname==fname&& student.lname == lname)
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Student
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string age { get; set; }
        public string town { get; set; }

        public override string ToString()
        {
            return $"{this.fname} {this.lname} is {this.age} years old.";
        }
    }
}
