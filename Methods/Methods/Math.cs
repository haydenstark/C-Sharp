using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Math
    {
        public static string Multiply(int input)
        {
            int result = input * 8;
            string output = input + " times 8 is " + result;
            return output;
        }

        public static string Addition(int input)
        {
            int result = input + 12;
            string output = input + " plus 12 is " + result;
            return output;
        }

        public static string Subtraction(int input)
        {
            int result = input - 5;
            string output = input + " minus 5 is " + result;
            return output;
        }

        //public static int Multiply(int input)
        //{
        //    return input * 8;
        //}

        //public static int Addition(int input)
        //{
        //    return input + 12;
        //}

        //public static int Subtraction(int input)
        //{
        //    return input - 5;
        //}
    }
}
