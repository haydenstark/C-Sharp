using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static bool operator== (Employee a, Employee b)
        {
            return a.ID == b.ID;
        }
        public static bool operator!= (Employee a, Employee b)
        {
            return a.ID != b.ID;
        }
    }
}
