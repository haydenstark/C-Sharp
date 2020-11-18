using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strings = new Employee<string>();
            strings.Things = new List<string>() { "These", "are", "some", "strings" };

            Employee<int> ints = new Employee<int>();
            ints.Things = new List<int>() { 1, 2, 3, 4 };


            foreach (string thing in strings.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in ints.Things)
            {
                Console.WriteLine(thing);
            }


            Console.Read();
        }
    }
}
