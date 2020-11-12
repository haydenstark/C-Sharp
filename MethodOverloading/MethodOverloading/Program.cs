using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a whole number and we'll multiply it by 4:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.DoMath(userInput));

            Console.WriteLine("\nGive me a decimal value and we'll divide it by 2.5 (and round it to a whole value):");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.DoMath(userInput2));

            Console.WriteLine("\nGive me a whole number and we'll subtract 12 from it:");
            string userInput3 = Console.ReadLine();
            Console.WriteLine(Math.DoMath(userInput3));

            Console.WriteLine("\nOne last time - give me a number (preferably a whole number) and we'll repeat all three operations:");
            string asString = Console.ReadLine();
            int asInt = Convert.ToInt32(asString);
            decimal asDec = Convert.ToDecimal(asString);
            Console.WriteLine(Math.DoMath(asInt));
            Console.WriteLine(Math.DoMath(asDec));
            Console.WriteLine(Math.DoMath(asString));

            Console.Read();
        }
    }
}
