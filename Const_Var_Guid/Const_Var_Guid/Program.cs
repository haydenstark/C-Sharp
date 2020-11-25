using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Guid
{
    class Program
    {
        static void Main(string[] args)
        {
            const string hogwarts = "Hogwarts School of Witchcraft and Wizardry";
            var harry = new Person("Harry Potter");

            Console.WriteLine(harry.Name);
            Console.WriteLine(harry.Year);
            Console.WriteLine(hogwarts);

            harry.ID = Guid.NewGuid();
            Console.WriteLine(harry.ID);

            Console.Read();
        }
    }
}
