using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {first} {last_name}.");
    }
}