using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Boss: Employee
    {
        public bool Car { get; set;}
        private double BonusReal { get; set; }
        public double Bonus
        { 
            get
            {
                return BonusReal;
            }
            set
            {
                if (value >= 0) BonusReal = value;
                else Console.WriteLine("Bonus is not a bonus if it is negative you dummy!");
            }
        }
        public Boss()
        {

        }
        public Boss(string first, string last, string prof, int salary, bool car, double bonus)
            :base(first, last, prof, salary)
        {
            Firstname = first;
            Lastname = last;
            Profession = prof;
            Salary = salary;
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + " Car at park: " + Car + " Bonus: " + Bonus;
        }
    }
}
