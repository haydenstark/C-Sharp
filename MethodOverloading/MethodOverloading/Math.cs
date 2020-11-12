using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Math
    {
        public static int DoMath(int input)
        {
            return input * 4;
        }
        public static int DoMath(decimal input)
        {
            return Convert.ToInt32( input / 2.5m );
        }
        public static int DoMath(string input)
        {
            int intInput = Convert.ToInt32(input);
            return intInput - 12;
        }
    }
}
