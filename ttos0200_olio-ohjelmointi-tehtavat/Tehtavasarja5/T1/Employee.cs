using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        private int SalaryReal { get; set; }
        public int Salary
        {
            get
            {
                return SalaryReal;
            }
            set
            {
                if (value >= 0) SalaryReal = value;
                else
                {
                    Console.WriteLine("Do you seriously pay us for working here? Rough Deal Bro...");
                }
            }
        }

        public Employee()
        {
            Profession = "Unemplyed";
            Salary = 0;
        }
        public Employee(string first, string last, string prof,int salary)
        {
            Firstname = first;
            Lastname = last;
            Profession = prof;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + Firstname + " " + Lastname + " Profession:  " + Profession + " Salary: " + Salary; 
        }

    }
}
