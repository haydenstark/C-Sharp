using System;
using System.Text;


class Program
{
    static void Main()
    {
        string hi = "Hi, my name is";
        string name = "Bruce Wayne";
        string alterEgo = "Batman";

        Console.WriteLine(hi + " " + name + ", but you can call me " + alterEgo + ".");
        Console.WriteLine("\n" + alterEgo.ToUpper());

        StringBuilder sb = new StringBuilder("\nI was thinking I was going to continue on the Batman theme.");
        sb.AppendLine(" Unfortunately, I'm not creative today.");
        sb.AppendLine("Oops, oh well.");
        sb.AppendLine("Na na na na na na na na na na na na na na na na BATMAN.");

        Console.WriteLine(sb);
        Console.Read();
    }
}

