class Menu
{
    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("  1. Add video");
        Console.WriteLine("  2. Show videos");
        Console.WriteLine("  3. Quit");
        Console.Write("Choose one of the options: ");
        return int.Parse(Console.ReadLine());
    }
}