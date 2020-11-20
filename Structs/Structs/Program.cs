using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number pi = new Number() { Amount = 3.14159m };

            Console.WriteLine(pi.Amount);
            Console.Read();
        }
    }
}
