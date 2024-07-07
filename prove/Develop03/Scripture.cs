class Scripture
{
    private readonly string _reference;
    private readonly List<Word> _words;

    public bool AllWordsHidden => _words.All(word => word.IsHidden);

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {string.Join(" ", _words.Select(word => word.IsHidden ? "_____" : word.Text))}");
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Any())
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            var wordToHide2 = visibleWords[random.Next(visibleWords.Count)];
            var wordToHide3 = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            wordToHide2.Hide();
            wordToHide3.Hide();
        }
    }
}