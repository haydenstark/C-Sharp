﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() { firstName = "Sample", lastName = "Student" };
            sample.SayName();



            IQuittable quitTest = new Employee();
            quitTest.Quit();

            Console.Read();
        }
    }
}