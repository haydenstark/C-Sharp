using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a whole number and we'll divide it by 2:");
            int x = Convert.ToInt32(Console.ReadLine());

            Math.DoMath(x, out int thrownVar);
            Console.WriteLine(thrownVar);


            Console.WriteLine("\nGive me a decimal value and we'll multiply it by 4.12:");
            decimal y = Convert.ToDecimal(Console.ReadLine());

            Math.DoMath(y, out decimal thrownVar2);
            Console.WriteLine(thrownVar2);

            Console.Read();
        }
    }
}
