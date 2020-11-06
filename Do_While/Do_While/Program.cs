using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Give me a number between 1-10");
        int input = Convert.ToInt32(Console.ReadLine());
        bool lessThan = true;

        while (lessThan)
        {
            Console.WriteLine("Cycles left until finished: " + (10 - input));
            input++;
            if (input > 10)
            {
                lessThan = false;
            }
        }

        Console.WriteLine("\nWhat's the best day of the week?");
        string day = Console.ReadLine();
        bool guessed = false;

        do
        {
            switch (day)
            {
                case "Thursday":
                    Console.WriteLine("\nYES!\nWhy? Because it's payday!");
                    guessed = true;
                    break;
                default:
                    Console.WriteLine("\nNope, try again.");
                    Console.WriteLine("What's the best day of the week?");
                    day = Console.ReadLine();
                    break;
            }
        }
        while (!guessed);
        Console.Read();
    }
}
