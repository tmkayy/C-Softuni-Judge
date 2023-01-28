using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            while (true)
            {
                string[] Info = Console.ReadLine().Split(' ').ToArray();
                if (Info[0]=="end")
                {
                    break;
                }
                Student s = new Student();
                s.fname = Info[0];
                s.lname = Info[1];
                s.age = Info[2];
                s.town = Info[3];
                Students.Add(s);
            }
            string town = Console.ReadLine();
            foreach (Student student in Students)
            {
                if (student.town==town)
                {
                    Console.WriteLine(student);
                }
            }
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
