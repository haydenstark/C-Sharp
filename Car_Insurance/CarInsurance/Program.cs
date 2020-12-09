using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Car Insurance Approval Program");

        Console.WriteLine("\nHow old are you?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nHave you ever had a DUI? (Type \"True\" or \"False\")");
        bool DUI = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nHow many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        bool approved = age > 15 && DUI == false && tickets <= 3;
        Console.WriteLine("\nQualified?");
        Console.WriteLine(approved);
        Console.Read();
    }
}
