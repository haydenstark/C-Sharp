using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Guid
{
    public class Person
    {
        public Person(string name, string year)
        {
            Name = name;
            Year = year;
        }
        public Person(string name) : this(name, "is a first-year student")
        {
        }

        public string Name { get; set; }
        public string Year { get; set; }
        public Guid ID { get; set; }
    }
}
