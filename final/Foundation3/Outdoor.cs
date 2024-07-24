class OutDoor : Event
{
    private string _weather;
    public OutDoor(string name, string discription, string date, string time, Address address, string weather) : base(name, discription, date, time, address)
    {
        _weather = weather;
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"Event type: {base.ToString()}");
        DisplayStandard();
        Console.WriteLine($"Weather Forcast {_weather}");
    }
}