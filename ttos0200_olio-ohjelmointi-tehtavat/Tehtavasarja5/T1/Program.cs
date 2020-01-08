using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Aimo","Pesu","Insinööri",2000);
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss("Aimo", "Kyyti", "Projektipäällikkö", 5000, true, 0.4);
            Console.WriteLine(boss.ToString());
        }
    }
}
