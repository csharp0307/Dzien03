using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Jan", "Kowalski", 100);
            emp.RegisterTime1(5.5);
            emp.RegisterTime1(10);
            emp.RegisterTime1(1);
            emp.PaySalary1();
        }
    }
}
