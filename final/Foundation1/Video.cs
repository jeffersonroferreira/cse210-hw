class Video
{

    private string _title;
    private string _author;
    private int _vidLength;

    List<Comment> _comments = new List<Comment>();
public Video(string title, string author, int length)
{
    _title = title;
    _author = author;
    _vidLength = length;
}
public Video()
{}
    public void SetText()
    {
        Console.Write("What is the title of the video?: ");
        _title = Console.ReadLine();
        Console.Write("Who made the video?: ");
        _author = Console.ReadLine();
        Console.Write("How long is the video?: ");
        _vidLength = int.Parse(Console.ReadLine());

    }
    public void Display()
    {
        Console.WriteLine($"{_title}, made by {_author}, Video is {_vidLength} seconds long");
    }
    public void GetTitle()
    {
        Console.Write(_title);
    }
    public string Getauthor()
    {
        return _author;
    }
    public void DisplayComments()
    {
        Console.WriteLine("Comments made: ");
        foreach (Comment i in _comments)
        {
            Console.Write("    ");
            i.DisplayComment();
        }
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void MakeComment()
    {
        bool input = false;
        while (!input)
        {
            string response;

            Comment comment = new Comment();
            comment.MakeComment();
            _comments.Add(comment);
            Console.Write("Add another Comment? (Y/N): ");
            response = Console.ReadLine();

            if (response == "N")
            {
                input = true;
            }

        }

    }
}