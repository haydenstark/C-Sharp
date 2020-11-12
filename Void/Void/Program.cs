using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math variableMath = new Math();      - instantiating, but commenting it out considering the class only has a method and isn't being populated with anything

            Math.DoMath(6, 7);
            
            Math.DoMath(a: 5, b:8);             // named parameters

            Console.Read();
        }
    }
}
