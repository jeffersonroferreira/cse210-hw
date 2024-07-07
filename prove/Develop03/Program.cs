using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture memorizer instance
        var memorizer = new Reference();

        // Display the scripture and hide words until all are hidden
        memorizer.StartMemorizing();

        Console.WriteLine(">>> Press ENTER to exit. <<<");
        Console.ReadLine();
    }
}
