using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        string[] adjectives = { "Tiny", "Fuzzy", "Cute", "Huggable", "Friendly" };

        Console.WriteLine("Hello and welcome to smol-inator program.");
        Console.WriteLine("Please type a terrifying animal:");
        string input = Console.ReadLine();
        Console.WriteLine("");

        for (int i = 0; i < adjectives.Length; i++)
        {
            adjectives[i] = adjectives[i] + " " + input;
        }

        foreach (string adj in adjectives)
        {
            Console.WriteLine(adj);
        }


        Console.WriteLine("");

        bool infinite = true;
        int k = 0;
        while (infinite)
        {
            Console.WriteLine(input);
            k++;
            // the fix:
            if (k > 5)
            {
                infinite = false;
            }
        }

        Console.WriteLine("");
        int j = 0;
        while ( j < 3)
        {
            Console.WriteLine(adjectives[0]);
            j++;
        }


        Console.WriteLine("");
        int z = 0;
        while (z <= 5)
        {
            Console.WriteLine(adjectives[1]);
            z++;
        }


        List<string> animals = new List<string> { "bear", "scorpion", "tiger", "spider", "wasp" };
        Console.WriteLine("\nCan you guess an animal from our list of terrifying animals?:");
        string guess = Console.ReadLine().ToLower();

        for (int q = 0; q < animals.Count; q++)
        {
            if (guess == animals[q])
            {
                Console.WriteLine("List index: " + q);
                Console.WriteLine("Correct - " + guess + " was in our list of terrifying animals!");
                break;
            }
        }

        if (!animals.Contains(guess))
        {
            Console.WriteLine("Terrifying indeed! But not one in our list.");
        }



        List<string> cute = new List<string> { "kitten", "puppy", "dog", "puppy", "otter", "otter", "hamster" };
        Console.WriteLine("\nCan you guess an animal from our list of adorable animals?:");
        string guess2 = Console.ReadLine().ToLower();

        for (int w = 0; w < cute.Count; w++)
        {
            if (guess2 == cute[w])
            {
                Console.WriteLine("List index: " + w);
            }
        }

        if (cute.Contains(guess2))
        {
            Console.WriteLine("Corret - " + guess2 + " was in our list of adorable animals!");
        }

        if (!cute.Contains(guess2))
        {
            Console.WriteLine("Absolutely adorable, but unfortunately not in our list.");
        }


        int count = 0;
        List<string> duplicates = new List<string>();
        
        foreach (string c in cute)
        {
            bool appeared = false;
            Console.WriteLine("\n" + c);
            Console.WriteLine("Has already appeared in the list?:");
            for ( int m = 0; m < count; m++)
            {
                if (c == cute[m])
                {
                    appeared = true;
                    duplicates.Add(cute[m]);
                    break;
                }
            }
            Console.WriteLine(appeared);
            count++;
        }

        Console.WriteLine("\n\nThe duplicate strings are:");
        foreach (string duplicate in duplicates)
        {
            Console.WriteLine(duplicate);
        }

        Console.Read();
    }
}
