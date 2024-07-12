
class Reflection : Activity
{
    public Reflection(string title, string description) : base(title, description) { }

    List<string> starter = new List<string>();
    List<string> questions = new List<string>();
    Random ranInt = new Random();
    public void RunActivity()
    {
        DisplayWelcome();
        DisplayInstruction();
        PromptForTime();
        Console.Clear();
        Console.WriteLine("\nGet Ready...");
        Spinner(2);
        Console.Clear();

        RandomPrompt();
        while (!Timer())
        {
            RandomQuestion();
            Spinner(1);
            CountDown(5);
            Console.WriteLine("Ponder...");
            Spinner(5);
            CountDown(5);
        }
        EndMessage();

    }

    private void RandomPrompt()
    {
        starter.Add("Think of a time when you stood up for someone else.");
        starter.Add("Think of a time when you felt the Holy Ghost");
        starter.Add("Think of a time you did somthing selfless");
        starter.Add("Think of a time when you did something really difficult.");
        starter.Add("Think of a time when you helped someone in need.");
        int length = starter.Count();
        Console.WriteLine(starter[ranInt.Next(length)]);
        Spinner(5);
        CountDown(5);
    }
    private void RandomQuestion()
    {
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        questions.Add("Where were you during this experience?");
        int length = questions.Count();
        Console.WriteLine(questions[ranInt.Next(length)]);
    }
}