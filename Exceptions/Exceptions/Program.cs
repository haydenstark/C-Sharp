using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter your age (in years):");

                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter a whole number");
                }

                if (age < 0) throw new NegativeAgeException();
                if (age == 0) throw new Age_DNE_Exception();

                DateTime now = DateTime.Now;
                age *= -1;          // flipping to a negative number so when AddYears method is used, the years are instead subtracted
                Console.WriteLine("You were most likely born in: " + now.AddYears(age).Year);
            }
            catch (Age_DNE_Exception)
            {
                Console.WriteLine("Age can not be zero. Please restart application.");
            }
            catch (NegativeAgeException)
            {
                Console.WriteLine("Age can not be negative. Please restart application.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, please restart application.");
            }


            Console.Read();
        }
    }
}
