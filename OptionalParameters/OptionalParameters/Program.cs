using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide two numbers to do some multiplication");
            Console.WriteLine("NOTE - The second number is completely optional, a value of 3 will be used if left blank");

            Console.WriteLine("\nFirst number:");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSecond number (press enter/return to leave blank):");
                string input2 = Console.ReadLine();

                if (input2 == "")
                {
                    Console.WriteLine("\nResult:\n" + Math.DoMath(input));
                }
                else
                {
                    int optional = Convert.ToInt32(input2);
                    Console.WriteLine("\nResult:\n" + Math.DoMath(input, optional));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " - (Please enter a number)");
            }
            finally
            {
                Console.Read();
            }
            
        }
    }
}
