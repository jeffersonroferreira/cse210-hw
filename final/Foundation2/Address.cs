class Address
{
    private string _streetnumber;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetnumber,string city,string state,string country)
    {
        _streetnumber = streetnumber;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Display()
    {
        Console.WriteLine($"{_streetnumber}, {_city}: {_state}, {_country}");
    }
}