using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Age_DNE_Exception : Exception
    {
        public Age_DNE_Exception()
            : base() { }
        public Age_DNE_Exception(string message)
            : base(message) { }
    }
}
