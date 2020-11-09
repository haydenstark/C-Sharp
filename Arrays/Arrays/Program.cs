using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] intArray = { 3, 7, 13, 21, 27 };
        string[] dayArray = { "Joyous", "Restful", "Productive", "Peaceful", "Stress-free" };

        List<string> avoidList = new List<string>();
        avoidList.Add("Confrontation");
        avoidList.Add("Heavy traffic");
        avoidList.Add("Excessive sugars");
        avoidList.Add("Coworkers");
        avoidList.Add("Emotionally taxing situations");

        Console.WriteLine("Hello! And welcome to the Fortune-Telling Program");
        Console.WriteLine("Please select a number between 1-5 to receive your lucky number for the day:");
        int input1 = Convert.ToInt32(Console.ReadLine());

        while (input1 < 1 || input1 > 5)
        {
            Console.WriteLine("Whoops, we're sorry - please select a number between 1-5:");
            input1 = Convert.ToInt32(Console.ReadLine());
        }

        if (input1 >= 1 && input1 <= 5)
        {
            int numSelect = input1 - 1;
            Console.WriteLine("\nYour lucky number for today is:");
            Console.WriteLine("\t" + intArray[numSelect]);
        }
        



        Console.WriteLine("\nNext, please select a number between 1-5 to learn how your day will play out:");
        int input2 = Convert.ToInt32(Console.ReadLine());

        while (input2 < 1 || input2 > 5)
        {
            Console.WriteLine("Whoops, we're sorry - please select a number between 1-5:");
            input2 = Convert.ToInt32(Console.ReadLine());
        }

        if (input2 >= 1 && input2 <= 5)
        {
            int daySelect = input2 - 1;
            Console.WriteLine("\nIt's looking like your day will be:");
            Console.WriteLine("\t" + dayArray[daySelect]);
        }




        Console.WriteLine("\nLastly, please select a number between 1-5 to learn what you should avoid today:");
        int input3 = Convert.ToInt32(Console.ReadLine());

        while (input3 < 1 || input3 > 5)
        {
            Console.WriteLine("Whoops, we're sorry - please select a number between 1-5:");
            input3 = Convert.ToInt32(Console.ReadLine());
        }

        if (input3 >= 1 && input3 <= 5)
        {
            int avoidSelect = input3 - 1;
            Console.WriteLine("\nFor today, you should avoid:");
            Console.WriteLine("\t" + avoidList[avoidSelect]);
        }


        Console.WriteLine("\nThank you for using the Fortune-Telling Program.");
        Console.WriteLine("Take care!");
        Console.Read();
    }
}
