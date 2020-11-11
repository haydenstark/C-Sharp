using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a whole number and we'll do some math on it!:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Multiply(input));
            Console.WriteLine(Math.Addition(input));
            Console.WriteLine(Math.Subtraction(input));

            Console.Read();
        }
    }
}
