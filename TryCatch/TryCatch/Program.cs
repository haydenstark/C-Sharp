using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int> { 4, 5, 8, 9, 12 };

        Console.WriteLine("Give me a number:");

        try
        {
            int userNum = Convert.ToInt32(Console.ReadLine());


            foreach (int num in intList)
            {
                int result = num / userNum;
                Console.WriteLine(num + " divided by " + userNum + " is: \t" + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("(Please type a number)");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("(Please do not divide by zero)");
        }

        Console.WriteLine("\nTry/catch block complete, continuing...");
        Console.Read();
    }
}
