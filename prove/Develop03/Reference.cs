class Reference
{
    private readonly Scripture _scripture;

    public Reference()
    {
        // You can initialize your scripture here
       _scripture = new Scripture("Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the childrem of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    }

    public void StartMemorizing()
    {
        do
        {
            Console.Clear();
            _scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            _scripture.HideRandomWord();
        } while (!_scripture.AllWordsHidden);
            Console.Clear();
            _scripture.Display();
            
        Console.WriteLine("\nCongratulations! You have memorized the scripture.");
    }
}