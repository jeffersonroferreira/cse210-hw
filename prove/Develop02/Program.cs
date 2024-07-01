using System;
using System.ComponentModel.Design.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        string userChoice = "-1";
        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            
            switch (userChoice)
            {
                // Write.
                case "1":
                PromptGenerator promptRnd = new PromptGenerator();
                string promptRandom = promptRnd.GetRandomPrompt();
                Console.WriteLine(promptRandom);
                string inputText = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = promptRandom;
                newEntry._entryText = inputText;
                journal1.AddEntry(newEntry);

                break;

                // Display.
                case "2":
                //Journal journal2 = new Journal();
                journal1.DisplayAll();
                break;

                // Load.
                case "3":
                Console.WriteLine("What is the file name?");
                string fileNameLoad = Console.ReadLine();
                journal1.LoadFromFile(fileNameLoad);
                break;

                // Save.
                case "4":
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                journal1.SaveToFile(fileName);
                break;

                case "5":
                Console.WriteLine("Goodbye!");
                return;

                // default.
                default:
                Console.WriteLine("Please enter a valid choice.");
                break;

            }
        }
    }
}