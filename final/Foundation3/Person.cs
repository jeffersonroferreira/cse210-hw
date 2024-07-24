class Person
{
    private string _name;
    private List<string> names = new List<string>();
    
    public Person(string name)
    {
        _name = name;
    }
    public string Name()
    {
            return _name;
    }
}