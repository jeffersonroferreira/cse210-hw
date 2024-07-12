

class Menu
{
    public int DisplayMenu()
    {
        int input = 0;
        while (input < 1 || input > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the Menu: ");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be a valid intager seen on the list.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }
        return input;

    }

}