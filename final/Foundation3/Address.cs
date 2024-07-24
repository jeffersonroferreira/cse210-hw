class Address
{
    private string _streetnumber;
    private string _city;
    private string _state;
    public Address(string streetnumber,string city,string state)
    {
        _streetnumber = streetnumber;
        _city = city;
        _state = state;
    }
    
    public void Display()
    {
        Console.Write($"{_streetnumber}, {_city}: {_state}");
    }
}