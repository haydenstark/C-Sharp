using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(true && false);
        Console.WriteLine(true && true);
        Console.WriteLine(false && false);

        Console.WriteLine("\n");
        Console.WriteLine(true || false);
        Console.WriteLine(true || true);
        Console.WriteLine(false || false);

        Console.WriteLine("\n");
        Console.WriteLine(true == false);
        Console.WriteLine(true == true);
        Console.WriteLine(false == false);

        Console.WriteLine("\n");
        Console.WriteLine(true != false);
        Console.WriteLine(true != true);
        Console.WriteLine(false != false);

        Console.WriteLine("\n");
        Console.WriteLine(true ^ false);
        Console.WriteLine(true ^ true);
        Console.WriteLine(false ^ false);

        Console.Read();
    }
}

