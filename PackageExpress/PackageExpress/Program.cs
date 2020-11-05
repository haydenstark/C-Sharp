using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        Console.WriteLine("\nPlease enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Error: Package is too heavy to be shipped via Package Express.");
        }
        else
        {
            Console.WriteLine("\nPlease enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            if ((width + height + length) > 50)
            {
                Console.WriteLine("Error: Package is too big to be shipped via Package Express");
            }
            else
            {
                float cost = (float)((height * width * length) * weight) / 100;
                Console.WriteLine("\nYour estimated total for shipping this package is: $" + cost);
                Console.WriteLine("Thank you!");
            }
        }
        Console.Read();
    }
}
