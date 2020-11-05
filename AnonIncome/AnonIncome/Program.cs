using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("\nPerson 1");
        Console.WriteLine("Please enter hourly rate: ");
        float p1Rate = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter hours worked per week: ");
        float p1Hours = float.Parse(Console.ReadLine());

        Console.WriteLine("\nPerson 2");
        Console.WriteLine("Please enter hourly rate: ");
        float p2Rate = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter hours worked per week: ");
        float p2Hours = float.Parse(Console.ReadLine());

        Console.WriteLine("\nAnnual salary of Person 1: ");
        float p1Week = p1Rate * p1Hours;
        double p1Salary = p1Week * 52;
        Console.WriteLine(p1Salary);

        Console.WriteLine("\nAnnual salary of Person 2: ");
        float p2Week = p2Rate * p2Hours;
        double p2Salary = p2Week * 52;
        Console.WriteLine(p2Salary);

        Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
        bool isMore = p1Salary > p2Salary;
        Console.WriteLine(isMore);
        Console.Read();
    }
}

