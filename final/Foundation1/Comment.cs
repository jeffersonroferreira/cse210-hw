class Comment
{
    private string _name;
    private string _text;
public Comment(string name, string text)
{
    _name = name;
    _text = text;
}
public Comment()
{}
    public string MakeComment()
    {
        Console.Write("Who made the Comment?: ");
        _name = Console.ReadLine();
        Console.Write("What does the comment say?: ");
        _text = Console.ReadLine();
        return $"{_name}, said : {_text}";
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}