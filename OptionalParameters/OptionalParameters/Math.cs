using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Math
    {
        public static int DoMath(int input, int optional = 3)
        {
            return input * optional;
        }
    }
}
