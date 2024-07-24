using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Address address1 = new Address("8035 mediteranion way", "Abandoned", "Texas");
        Address address2 = new Address("2400 lefthold ave", "Town", "Onterio");
        Person person1 = new Person("Benny@example.com");
        Person person2 = new Person("Rosy@example.com");
        Person person3 = new Person("Sarah@example.org");
        Person person4 = new Person("Ben@example.com");
        Person person5 = new Person("Lexi@example.com");
        Person person6 = new Person("Carlos@example.org");
        events.Add(new Lecture("company", "informational lecture to better unite teams", "5/26/12", "2:45", address2, "BoBurnhame", 500));
        Reception rec1 = new Reception("Wedding", "Bill & Margret", "7/12/24", "9:00", address1);
        OutDoor outDoor= new OutDoor("Reunion", "Large Family get together", "7/18/08", "5:00", address2, "Sunny/Heat warning");
        rec1.AddPerson(person1);
        rec1.AddPerson(person2);
        rec1.AddPerson(person3);
        rec1.AddPerson(person4);
        rec1.AddPerson(person5);
        rec1.AddPerson(person6);
        events.Add(outDoor);
        events.Add(rec1);
        bool _roll = true;
        while (_roll == true)
        {
            int response = 0;
            Console.Clear();
            Console.WriteLine("1. List events\n2. Quit");
            response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    foreach (Event e in events)
                    {
                        Console.Clear();
                        e.DisplayFull();
                        Console.Write("Press enter to Continue");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    _roll = false;
                    break;
            }
        }
    }
}