using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }
        public Student(string firstName, string lastName, string studentID)
            :base(firstName, lastName)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
        }
        public void StudentMethod()
        {
            Console.WriteLine("This belongs to a Student!");
        }
        public override string ToString()
        {
            return base.ToString() + " Studnt number: " + StudentID; 
        }
    }
}
