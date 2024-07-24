class Lecture : Event
{
private string _speaker;
private int _capacity;
public Lecture(string name, string discription, string date, string time, Address address, string speaker, int capacity) : base(name, discription, date, time, address)
{
_speaker = speaker;
_capacity = capacity;
}
    public override void DisplayFull()
    {
        Console.WriteLine($"Event type: {base.ToString()}");
        DisplayStandard();
        Console.WriteLine($"Guest speaker: {_speaker}, capacity: {_capacity}");
    }
}