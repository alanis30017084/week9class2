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
            Console.Write("Please enter your percentage tax as a decimal (0-1): ");
            double tax = double.Parse(Console.ReadLine());

            Employee a1 = new Employee(fname, lname, salary, tax);
            // Fixed 'a1.Fname' to be called instead of 'fname', same for rest of the values.
            Console.WriteLine($"\nYour details are\n\nFull name: {a1.Fname} {a1.Lname}\nNet salary (after tax): {a1.NetSalary(a1.Salary, a1.Tax)}");
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
            // Fixed NetSalary method to round to 2 d.p., fixed capitalisation of salary & tax.
            return Math.Round(Salary - (Salary * Tax), 2);
        }

        public Employee(string _fname, string _lname, double _salary, double _tax)
        {
            Fname = _fname;
            Lname = _lname;
            Salary = _salary;
            Tax = _tax;
        }

    }
}
