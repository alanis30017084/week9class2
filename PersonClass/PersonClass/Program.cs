using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alanis", "Correa", 21);
            Console.WriteLine($"Details\nName: {p1.Fname} {p1.Lname}\nAge: {p1.Age}");
            Console.ReadLine();
        }
    }

    class Person
    {
        string fname;
        string lname;
        int age;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        // Can't access Age if set to private

        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }

    }
}
