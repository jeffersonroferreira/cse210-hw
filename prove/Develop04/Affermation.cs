class Affermation : Activity
{
    public Affermation(string title, string description) : base(title, description) { }

    public void test()
    {
        DisplayWelcome();
        DisplayInstruction();
        Console.WriteLine("For this Activity we ask you use Increments of 15 seconds");
        PromptForTime();
        Spinner(1);
        Console.WriteLine("\nGet Ready...");
        Spinner(2);

        while(!Timer())
        {
            
        }


    }

}