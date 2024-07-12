
class Breathing : Activity
{
    public Breathing(string title, string description) : base(title, description) { }

    public void RunActivity()
    {
        DisplayWelcome();
        DisplayInstruction();
        Console.WriteLine("\nFor this Activity please use Increments of 10s");
        PromptForTime();
        Console.Clear();
        Console.WriteLine("\nGet Ready...");
        Spinner(2);

        while (!Timer())
        {
            Console.Write("\nBreath In...");
            CountDown(3);
            Console.WriteLine("\n");
            Console.Write("Hold...");
            CountDown(3);
            Console.WriteLine("\n");
            Console.Write("Breath Out...");
            CountDown(4);
            Console.WriteLine();
        }
        EndMessage();

    }


}