using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Math
    {
        public static void DoMath(int x, out int thrownVar)
        {
            thrownVar = x / 2;
        }

        public static void DoMath(decimal y, out decimal thrownVar2)
        {
            thrownVar2 = y * 4.12m;
        }
    }
}
