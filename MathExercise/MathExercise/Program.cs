using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Give me a number and I will multiply it by 50: ");
        double input1 = Convert.ToDouble(Console.ReadLine());
        double product = input1 * 50;
        Console.WriteLine(input1 + " multiplied by 50 is " + product);

        Console.WriteLine("\nGive me a whole number and I will add 25 to it: ");
        int input2 = Convert.ToInt32(Console.ReadLine());
        int sum = input2 + 25;
        Console.WriteLine(input2 + " plus 25 is " + sum);

        Console.WriteLine("\nGive me a number and I will divide it by 12.5: ");
        double input3 = Convert.ToDouble(Console.ReadLine());
        double quotient = input3 / 12.5;
        Console.WriteLine(input3 + " divided by 12.5 is " + quotient);

        Console.WriteLine("\nGive me a number and I will check if it's greater than 50: ");
        float input4 = float.Parse(Console.ReadLine());
        bool isGreater = input4 > 50;
        Console.WriteLine("Is " + input4 + " greater than 50?: " + isGreater);

        Console.WriteLine("\nGive me a whole number and I will tell you if it has a remainder when divided by 7: ");
        int input5 = Convert.ToInt32(Console.ReadLine());
        int modulus = input5 % 7;
        Console.WriteLine(input5 + " divided by 7 has a remainder of " + modulus);
        Console.Read();
    }
}

