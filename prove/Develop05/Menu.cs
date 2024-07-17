class Menu
{
    public int DisplayMenu()
    {
        int input;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goal");
            Console.WriteLine("  3. Save Goal");
            Console.WriteLine("  4. Load Goal");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            return input = int.Parse(Console.ReadLine());
        } while (input != 6);
    }
    public int CreateActivityMenu()
    {
        int input;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple");
        Console.WriteLine("  2. Eternal");
        Console.WriteLine("  3. Check List");
        Console.Write("Which type of goal would you like to create? ");
        
        return input = int.Parse(Console.ReadLine());

    }
}