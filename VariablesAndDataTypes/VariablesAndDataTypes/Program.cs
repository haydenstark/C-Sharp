using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Behold!   a comment
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What's your favorite number?");
            //string favNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -12;
            char questionMark = '\u2103';

            decimal money = 100.5m;
            double heightCM = 23.32112435;
            float seconds = 2.34f;
            short tempOnMars = -341;
            string name = "Patricia";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

        }
    }
}
