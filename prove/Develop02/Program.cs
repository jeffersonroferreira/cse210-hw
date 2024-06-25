using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Entry myEntry = new Entry();
        myEntry._date = "2024/06/25";
        myEntry._promptText = "What was the best part of your day?";
        myEntry._entryText = "Dinner time with my family";

        myEntry.Display();
        
        
    }
}