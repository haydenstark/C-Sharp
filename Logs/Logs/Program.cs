using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and we'll log it:");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\james\Documents\Logs\log.txt", input);

            string txtfile = File.ReadAllText(@"C:\Users\james\Documents\Logs\log.txt");
            Console.WriteLine(txtfile);

            Console.Read();
        }
    }
}
