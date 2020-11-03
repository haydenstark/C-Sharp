using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("\nWhat is your name?");
        string studentName = Console.ReadLine();
        
        Console.WriteLine("\nWhat course are you on?");
        string course = Console.ReadLine();
        
        Console.WriteLine("\nWhat page number?");
        string pageResponse = Console.ReadLine();
        int page = Convert.ToInt32(pageResponse);

        Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
        string helpResponse = Console.ReadLine();
        bool help = Convert.ToBoolean(helpResponse);

        Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
        string posExp = Console.ReadLine();

        Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("\nHow many hours did you study today?");
        string hoursResponse = Console.ReadLine();
        float hours = float.Parse(hoursResponse);
        // I would keep hours as a string (ie - I respond '2hrs' in the LMS), but for this exercise I figured I'd demonstrate another data type

        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Course: " + course);
        Console.WriteLine("Page: " + page);
        Console.WriteLine("Help?: " + help);
        Console.WriteLine("Positive Experience?: " + posExp);
        Console.WriteLine("Feedback: " + feedback);
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();
    }
}
