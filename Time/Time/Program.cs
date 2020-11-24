using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine("Give me a number:");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIn {0} hours, it will be:", input);
            Console.WriteLine(now.AddHours(input));

            Console.Read();
        }
    }
}
