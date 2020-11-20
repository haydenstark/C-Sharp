using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string guess = Console.ReadLine().ToLower();

            try
            {
                Day dayGuessed = (Day)Enum.Parse(typeof(Day), guess);
                Console.WriteLine(dayGuessed);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }



            //bool run = true;
            //while (run)
            //{
            //    Console.WriteLine("What day of the week is it?");

            //    string guess = Console.ReadLine().ToLower();

            //    if (!char.IsDigit(guess[0]))
            //    {
            //        try
            //        {
            //            Day dayGuessed = (Day)Enum.Parse(typeof(Day), guess);

            //            for (int i = 0; i < 7; i++)
            //            {
            //                if (dayGuessed == (Day)i)
            //                {
            //                    run = false;
            //                    Console.WriteLine("Thanks!");
            //                }
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Please enter an actual day of the week");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please do not use numbers");
            //    }
            //}

            Console.Read();
        }
        
        public enum Day
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
