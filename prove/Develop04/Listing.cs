
class Listing : Activity
{
    public Listing(string title, string description) : base(title, description) { }
    List<string> questions = new List<string>();
    List<string> listItems = new List<string>();
    Random ranInt = new Random();

    public void RunActivity()
    {
        int length;
        DisplayWelcome();
        DisplayInstruction();
        Console.WriteLine("we will show a question for 10 seconds to ponder. we ask you facter that in while selecting your time.");
        PromptForTime();
        Console.Clear();
        Console.WriteLine("After this count down List one item and then press enter (repeat)\nWe will display a 3 second countdown once the time is up.");
        CountDown(10);
        RandomQuestion();

        while (!Timer())
        {
            string item = Console.ReadLine();
            listItems.Add(item);
            length = listItems.Count();
            Console.WriteLine($"You have listed {length} items.");
        }
        EndMessage();
    }
    private void RandomQuestion()
    {
        questions.Add("Who are people that you appreciate?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");
        questions.Add("What are personal strengths of yours?");
        int length = questions.Count();
        Console.WriteLine(questions[ranInt.Next(length)]);
    }
}