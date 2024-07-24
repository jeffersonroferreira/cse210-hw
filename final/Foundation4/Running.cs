class Running : Activity
{
    private int _distance;
    public Running(string date, int lengthMinutes, int distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }
    private int Pace(int time, int distance)
    {
        int pace = 0;
        return pace = time / distance;
    }
    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"- Distance {_distance} Miles, Speed {Speed(Pace(GetTime(), _distance))}mph, Pace {Pace(GetTime(), _distance)} min per mile");
    }

}