using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            //Employee joe = new Employee() { FirstName = "Joe", LastName = "Johnson", ID = 72 };
            //joe.SayName();
            //Console.WriteLine(joe.ID);

            Console.Read();
        }
    }
}
