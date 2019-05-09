using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lname = Console.ReadLine();
            Console.Write("Please enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Please enter your percentage tax: ");
            double tax = double.Parse(Console.ReadLine());

            Employee a1 = new Employee(fname, lname, salary, tax);
            Console.WriteLine($"\nYour details are\n\nFull name: {fname} {lname}\nNet salary (after tax): {a1.NetSalary(salary, tax)}");
            Console.ReadLine();
        }
    }

    class Employee
    {
        string fname;
        string lname;
        double salary;
        double tax;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public double Tax { get { return tax; } set { tax = value; } }

        public double NetSalary(double _salary, double _tax)
        {
            return Math.Round(salary - (salary * (tax / 100)), 2);
            // Returns 0... needs fix, ran out of time.
        }

        public Employee(string _fname, string _lname, double _salary, double _tax)
        {
            Fname = fname;
            Lname = lname;
            Salary = salary;
            Tax = tax;
        }

    }
}
