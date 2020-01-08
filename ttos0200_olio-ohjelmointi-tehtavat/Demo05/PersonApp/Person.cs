using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {

        }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public void PersonMethod()
        {
            Console.WriteLine("Thi belongs to a person!");
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Age: " + Age + " Address: " + Address + " Phone number: " + PhoneNumber;
        }
    }
}
