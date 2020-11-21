using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { firstName = "Joe", lastName = "Johnson", ID = 1 };
            Employee e2 = new Employee() { firstName = "Joe", lastName = "Robinson", ID = 2 };
            Employee e3 = new Employee() { firstName = "Deborah", lastName = "Gains", ID = 3 };
            Employee e4 = new Employee() { firstName = "Deputy", lastName = "Seargent", ID = 4 };
            Employee e5 = new Employee() { firstName = "Billie", lastName = "Eilish", ID = 5 };
            Employee e6 = new Employee() { firstName = "Whitney", lastName = "Houston", ID = 6 };
            Employee e7 = new Employee() { firstName = "John", lastName = "Cena", ID = 7 };
            Employee e8 = new Employee() { firstName = "Charmin", lastName = "Bears", ID = 8 };
            Employee e9 = new Employee() { firstName = "Santa", lastName = "Clause", ID = 9 };
            Employee e10 = new Employee() { firstName = "Sham", lastName = "Wow", ID = 10 };

            List<Employee> employeesList = new List<Employee>() { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };



            foreach (Employee employee in employeesList)
            {
                if (employee.firstName == "Joe")
                {
                    Console.WriteLine(employee.firstName + " " + employee.ID);
                }
            }



            Console.WriteLine("\n");

            List<Employee> listOfJoes = employeesList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee joe in listOfJoes)
            {
                Console.WriteLine(joe.firstName + " " + joe.ID);
            }



            Console.WriteLine("\n");

            List<Employee> idList = employeesList.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }

            Console.Read();
        }
    }
}
