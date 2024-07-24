abstract class Event
{
    private string _name;
    private string _discription;
    private string _date;
    private string _time;
    Address _address;
    public Event(string name, string discription, string date, string time, Address address)
    {
        _name = name;
        _discription = discription;
        _date = date;
        _time = time;
        _address= address;
    }
public void DisplayStandard()
{
    Console.Write($"{_name}, {_discription}, ");
    _address.Display();
    Console.WriteLine($": {_date}, {_time}");
}
public abstract void DisplayFull();

}