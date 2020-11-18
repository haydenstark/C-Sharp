using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Barb = new Employee() { Name = "Barb", ID = 101 };
            Employee Nick = new Employee() { Name = "Nick", ID = 102 };
            Employee Leroy = new Employee() { Name = "Leroy Jenkins", ID = 101 };

            Console.WriteLine("Is equal:");
            Console.WriteLine(Barb == Leroy);
            Console.WriteLine(Nick == Barb);

            Console.WriteLine("\nIs NOT equal:");
            Console.WriteLine(Barb != Leroy);
            Console.WriteLine(Nick != Barb);
            Console.Read();
        }
    }
}
