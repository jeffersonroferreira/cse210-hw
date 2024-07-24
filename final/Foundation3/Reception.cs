class Reception : Event
{
    List<Person> _people = new List<Person>();
    public Reception(string name, string discription, string date, string time, Address address) : base(name, discription, date, time, address)
    {
    }
    public void AddPerson(Person name)
    {
        _people.Add(name);
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"Event type: {base.ToString()}");
        DisplayStandard();
        Console.WriteLine($"RSVPs: ");
        foreach (Person person in _people)
        {
            Console.WriteLine(person.Name());
        }
    }
}