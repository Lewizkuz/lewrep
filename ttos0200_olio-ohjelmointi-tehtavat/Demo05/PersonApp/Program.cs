using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Krenel";
            person.Age = 25;
            person.PhoneNumber = "0123123132";
            Console.WriteLine(person.ToString());

            Student student = new Student("Minna", "Husso", "K1234");
            student.Address = "Masintie 78";
            student.Age = 22;
            student.PhoneNumber = "0440-11111122";
            Console.WriteLine(student.ToString());

            student.PersonMethod();
            student.StudentMethod();
            person.PersonMethod();

        }
    }
}
